using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LiteDB;

namespace Flashies
{
    //View Helper Methods Below Form Class
    public partial class Form : System.Windows.Forms.Form
    {
        //Flashcard Set Class
        public class Flashcard
        {
            public string question { get; set; }
            public string answer { get; set; }
        }
        public class FlashcardSet
        {
            public long timestamp { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public List<Flashcard> flashcards { get; set; }
        }
        //UserControl List
        List<UserControl> userControls = new List<UserControl>();
        //Hides All UserControls and shows UserControl specified
        public void renderPage(UserControl page)
        {
            foreach (UserControl userControl in userControls)
            {
                userControl.Visible = false;
            };
            page.Visible = true;
            page.Controls.Cast<Control>().FirstOrDefault(x => x.TabIndex == 0).Select();
        }
        public Form()
        {
            InitializeComponent();
            //Style
            foreach (UserControl uc in Controls)
            {
                //Add Menus to UserControls List
                userControls.Add(uc);
                //Styling
                uc.BackColor = System.Drawing.Color.FromArgb(23, 26, 28);
                foreach (Control c in uc.Controls)
                {
                    c.ForeColor = System.Drawing.Color.White;
                    Console.WriteLine(c.Font.Size);
                    c.Font = new System.Drawing.Font("Bahnschrift Light", c.Font.Size < 10F ? 10F : c.Font.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                    if (c is Button)
                    {
                        Button btn = (Button)c;
                        btn.BackColor = System.Drawing.Color.FromArgb(34, 38, 42);
                        btn.FlatAppearance.BorderSize = 0;
                        btn.FlatStyle = FlatStyle.Flat;
                    }
                    if (c is TextBox)
                    {
                        TextBox txt = (TextBox)c;
                        if (txt.ReadOnly)
                        {
                            txt.BackColor = System.Drawing.Color.FromArgb(23, 26, 28);
                        }
                        else
                        {
                            txt.BackColor = System.Drawing.Color.FromArgb(34, 38, 42);
                        }
                    }
                    if (c is ListView)
                    {
                        ListView lv = (ListView)c;
                        lv.BackColor = System.Drawing.Color.FromArgb(34, 38, 42);
                    }
                }
            }
            /*
             * Add Event Listeners to Buttons
             */
            //Main Menu
            mainMenuUC.getControl("btnLearn").createClickHandler(menuLearn);
            mainMenuUC.getControl("btnCreate").createClickHandler(menuCreate);
            //Learn Menu
            learnMenuUC.getControl("btnExit").createClickHandler(exit);
            learnMenuUC.getControl("btnStart").createClickHandler(learnStart);
            //Create Menu
            createMenuUC.getControl("btnExit").createClickHandler(exit);
            createMenuUC.getControl("btnDelete").createClickHandler(setDelete);
            createMenuUC.getControl("btnNew").createClickHandler(createDetails);
            //Create Details
            createDetailsUC.getControl("btnExit").createClickHandler(exit);
            createDetailsUC.getControl("btnNext").createClickHandler(checkCreateDetails);
            //Create Question
            createQuestionUC.getControl("btnExit").createClickHandler(exit);
            createQuestionUC.getControl("btnNext").createClickHandler(checkCreateQuestion);
            createQuestionUC.getControl("btnFinish").createClickHandler(checkLastQuestion);
            //Learn Question
            learnQuestionUC.getControl("btnExit").createClickHandler(exit);
            learnQuestionUC.getControl("btnSubmit").createClickHandler(checkLearnQuestion);
            learnQuestionUC.getControl("txtAnswer").KeyPress += new System.Windows.Forms.KeyPressEventHandler(learnQuestionKeyPress);
            //Learn Question Result
            questionResultUC.getControl("btnExit").createClickHandler(exit);
            questionResultUC.getControl("btnContinue").createClickHandler(renderLearnQuestion);
            //Learn Results
            learnResultsUC.getControl("btnContinue").createClickHandler(menuLearn);

            //Render Main Menu
            renderPage(mainMenuUC);
        }
        //Global Variable Initialisation
        FlashcardSet learnSet = new FlashcardSet { };
        int learnCorrect = 0;
        int learnProgress = 0;
        FlashcardSet createSet = new FlashcardSet { };

        /*
         * GLOBAL METHODS
         */
        //Exit Function to Return to Main Menu
        public void exit(object sender, EventArgs e)
        {
            renderPage(mainMenuUC);
        }
        //Set Render Method for Learn and Create Menu
        public void renderSets(ListView listView)
        {
            using (var db = new LiteDatabase(@"flashies.db"))
            {
                var sets = db.GetCollection<FlashcardSet>("sets");
                var flashcardSets = sets.Find(Query.All("timestamp", Query.Ascending));
                listView.Items.Clear();
                foreach (FlashcardSet set in flashcardSets)
                {
                    listView.Items.Add(new ListViewItem(new string[] { set.id.ToString(), set.name, set.description }));
                };
            };
        }

        /*
         * LEARN FLASHCARDS
         */
        public void menuLearn(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            renderSets((ListView)learnMenuUC.getControl("listView"));
            //Render Learn Page
            renderPage(learnMenuUC);
        }
        public void learnStart(object sender, EventArgs e)
        {
            //Reset Global Variables
            learnProgress = 0;
            learnCorrect = 0;
            learnSet = new FlashcardSet { };
            //Find List Item
            var listView = (ListView)learnMenuUC.getControl("listView");
            if (listView.SelectedItems.Count == 1)
            {
                var setID = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);
                //Fetch Set from DB
                using (var db = new LiteDatabase(@"flashies.db"))
                {
                    var sets = db.GetCollection<FlashcardSet>("sets");
                    learnSet = sets.FindById(setID);
                    //Randomise Question Order
                    Random rng = new Random();
                    int n = learnSet.flashcards.Count;
                    while (n > 1)
                    {
                        n--;
                        int k = rng.Next(n + 1);
                        Flashcard value = learnSet.flashcards[k];
                        learnSet.flashcards[k] = learnSet.flashcards[n];
                        learnSet.flashcards[n] = value;
                    }
                    ((TextBox)learnQuestionUC.getControl("txtTitle")).Text = learnSet.name;
                    ((TextBox)questionResultUC.getControl("txtTitle")).Text = learnSet.name;
                    //Render Next Question
                    renderLearnQuestion(this, e);
                }
            }
        }
        public void renderLearnQuestion(object sender, EventArgs e)
        {
            if (learnProgress == learnSet.flashcards.Count)
            {   //Render Results
                int percentage = learnCorrect * 100 / learnSet.flashcards.Count;
                ((TextBox)learnResultsUC.getControl("txtTitle")).Text = learnSet.name;
                ((TextBox)learnResultsUC.getControl("txtCorrect")).Text = $"Score: {learnCorrect}/{learnSet.flashcards.Count} ({percentage}%)";
                renderPage(learnResultsUC);
            }
            else
            {
                //Render Next Question
                ((TextBox)learnQuestionUC.getControl("txtProgress")).Text = $"Q: {learnProgress + 1}/{learnSet.flashcards.Count}";
                ((TextBox)learnQuestionUC.getControl("txtScore")).Text = $"Correct: {learnCorrect}/{learnProgress}";
                ((TextBox)learnQuestionUC.getControl("txtQuestion")).Text = learnSet.flashcards[learnProgress].question;
                ((TextBox)learnQuestionUC.getControl("txtAnswer")).Text = "";
                renderPage(learnQuestionUC);
            }
        }
        private void learnQuestionKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                checkLearnQuestion(sender, e);
            }
        }
        public void checkLearnQuestion(object sender, EventArgs e)
        {
            var userAnswer = ((TextBox)learnQuestionUC.getControl("txtAnswer")).Text;
            if (userAnswer != "")
            {
                ((TextBox)questionResultUC.getControl("txtQuestion")).Text = learnSet.flashcards[learnProgress].question;
                ((TextBox)questionResultUC.getControl("txtProgress")).Text = $"Q: {learnProgress + 1}/{learnSet.flashcards.Count}";
                ((TextBox)questionResultUC.getControl("txtUserAnswer")).Text = $"Your Answer: {userAnswer}";
                ((TextBox)questionResultUC.getControl("txtCorrectAnswer")).Text = $"Correct Answer: {learnSet.flashcards[learnProgress].answer}";
                var txtResult = (TextBox)questionResultUC.getControl("txtResult");
                //Check Response
                bool correct = userAnswer.ToLower() == learnSet.flashcards[learnProgress].answer.ToLower();
                if (correct)
                {
                    learnCorrect++;
                    txtResult.Text = "Correct!";
                }
                else
                {
                    txtResult.Text = "Incorrect";
                }
                ((TextBox)questionResultUC.getControl("txtScore")).Text = $"Correct: {learnCorrect}/{learnProgress + 1}";
                learnProgress++;
                renderPage(questionResultUC);
            }
        }
        /*
         * CREATE FLASHCARDS
         */
        public void menuCreate(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            renderSets((ListView)createMenuUC.getControl("listView"));
            renderPage(createMenuUC);
        }
        public void setDelete(object sender, EventArgs e)
        {
            //Find List Item
            var listView = (ListView)createMenuUC.getControl("listView");
            if (listView.SelectedItems.Count == 1)
            {
                var setID = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);
                //Fetch Set from DB
                using (var db = new LiteDatabase(@"flashies.db"))
                {
                    var sets = db.GetCollection<FlashcardSet>("sets");
                    sets.Delete(setID);
                }
                //Re-render Menu
                menuCreate(this, e);
            }
        }
        public void createDetails(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            createSet = new FlashcardSet { };
            ((TextBox)createDetailsUC.getControl("txtName")).Text = "";
            ((TextBox)createDetailsUC.getControl("txtDesc")).Text = "";
            renderPage(createDetailsUC);
        }
        public void checkCreateDetails(object sender, EventArgs e)
        {
            var setName = ((TextBox)createDetailsUC.getControl("txtName")).Text;
            var setDesc = ((TextBox)createDetailsUC.getControl("txtDesc")).Text;
            if (setName != "" && setDesc != "")
            {
                createSet.name = setName;
                createSet.description = setDesc;
                createSet.flashcards = new List<Flashcard>();
                ((TextBox)createQuestionUC.getControl("txtTitle")).Text = setName;
                createNextQuestion();
                renderPage(createQuestionUC);
            }
        }

        public void createNextQuestion()
        {
            ((TextBox)createQuestionUC.getControl("txtQuestion")).Text = "";
            ((TextBox)createQuestionUC.getControl("txtAnswer")).Text = "";
            string cardCount = createSet.flashcards == null ? "1" : (createSet.flashcards.Count + 1).ToString();
            ((TextBox)createQuestionUC.getControl("txtQuestionNumber")).Text = $"Q: {cardCount}";
        }

        public void checkCreateQuestion(object sender, EventArgs e)
        {
            //Initialise New Flashcard
            Flashcard flashcard = new Flashcard
            {
                question = ((TextBox)createQuestionUC.getControl("txtQuestion")).Text,
                answer = ((TextBox)createQuestionUC.getControl("txtAnswer")).Text
            };
            //Check Flashcard Validity
            if (flashcard.question != "" && flashcard.answer != "")
            {
                createSet.flashcards.Add(flashcard);
                //Render Next Question Creation Panel
                createNextQuestion();
            }
        }
        public void checkLastQuestion(object sender, EventArgs e)
        {
            //Initialise New Flashcard
            Flashcard flashcard = new Flashcard
            {
                question = ((TextBox)createQuestionUC.getControl("txtQuestion")).Text,
                answer = ((TextBox)createQuestionUC.getControl("txtAnswer")).Text
            };
            //Check Flashcard Validity
            if (flashcard.question != "" && flashcard.answer != "")
            {
                createSet.flashcards.Add(flashcard);
                //Add Set to DB
                using (var db = new LiteDatabase(@"flashies.db"))
                {
                    var sets = db.GetCollection<FlashcardSet>("sets");
                    sets.Insert(createSet);
                }
                //Return to Create Menu
                menuCreate(this, e);
            }
        }
    }
    public static class ExtensionMethods
    {
        //Find Control Helper Method
        public static Control getControl(this UserControl userControl, string name)
        {
            return userControl.Controls.Find(name, false).FirstOrDefault();
        }
        //Create Click Handler Helper Method
        public static void createClickHandler(this Control button, EventHandler eventHandler)
        {
            button.Click += new System.EventHandler(eventHandler);
        }
    }
}
