using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;

namespace Flashies
{
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
            userControls.ForEach(delegate (UserControl userControl)
            {
                userControl.Visible = false;
            });
            page.Visible = true;
        }

        public Form()
        {
            InitializeComponent();
            //Add Menus to UserControl List
            foreach (UserControl c in Controls)
            {
                userControls.Add(c);
            }
            /*
             * Add Event Listeners to Buttons
             */
            //Main Menu
            mainMenuUC.Controls.Find("btnLearn", false).FirstOrDefault().Click += new System.EventHandler(menuLearn);
            mainMenuUC.Controls.Find("btnCreate", false).FirstOrDefault().Click += new System.EventHandler(menuCreate);
            //Learn Menu
            learnMenuUC.Controls.Find("btnExit", false).FirstOrDefault().Click += new System.EventHandler(exit);
            learnMenuUC.Controls.Find("btnStart", false).FirstOrDefault().Click += new System.EventHandler(learnStart);
            //Create Menu
            createMenuUC.Controls.Find("btnExit", false).FirstOrDefault().Click += new System.EventHandler(exit);
            createMenuUC.Controls.Find("btnDelete", false).FirstOrDefault().Click += new System.EventHandler(setDelete);
            createMenuUC.Controls.Find("btnNew", false).FirstOrDefault().Click += new System.EventHandler(createDetails);
            //Create Details
            createDetailsUC.Controls.Find("btnExit", false).FirstOrDefault().Click += new System.EventHandler(exit);
            //Learn Question
            learnQuestionUC.Controls.Find("btnExit", false).FirstOrDefault().Click += new System.EventHandler(exit);
            learnQuestionUC.Controls.Find("btnSubmit", false).FirstOrDefault().Click += new System.EventHandler(checkLearnQuestion);
            //Learn Question Result
            questionResultUC.Controls.Find("btnExit", false).FirstOrDefault().Click += new System.EventHandler(exit);
            questionResultUC.Controls.Find("btnContinue", false).FirstOrDefault().Click += new System.EventHandler(renderLearnQuestion);
            //Learn Results
            learnResultsUC.Controls.Find("btnContinue", false).FirstOrDefault().Click += new System.EventHandler(menuLearn);
            //Render Main Menu
            renderPage(mainMenuUC);

            //Init a Testing Set
            using (var db = new LiteDatabase(@"flashies.db"))
            {
                var sets = db.GetCollection<FlashcardSet>("sets");
                /*var set = new FlashcardSet
                {
                    timestamp = DateTimeOffset.Now.ToUnixTimeSeconds(),
                    name = "Periodic Table: Beginnings",
                    description = "The first 3 elements of the periodic table.",
                    flashcards = new List<Flashcard> {new Flashcard{
                        question = "What is the first element of the periodic table?",
                        answer = "Hydrogen"
                        }, new Flashcard{
                        question = "What is the second element of the periodic table?",
                        answer = "Helium"
                        }, new Flashcard{
                        question = "What is the third element of the periodic table?",
                        answer = "Lithium"
                        },
                    }
                };
                sets.Insert(set);*/
            }
        }
        FlashcardSet learnSet = new FlashcardSet { };
        int learnCorrect = 0;
        int learnProgress = 0;
        FlashcardSet createSet = new FlashcardSet { };

        //Render Question for Learn
        public void renderLearnQuestion(object sender, EventArgs e)
        {
            if (learnProgress == learnSet.flashcards.Count)
            {   //Render Results
                int percentage = learnCorrect * 100 / learnSet.flashcards.Count;
                ((TextBox)learnResultsUC.Controls.Find("txtTitle", false).FirstOrDefault()).Text = learnSet.name;
                ((TextBox)learnResultsUC.Controls.Find("txtCorrect", false).FirstOrDefault()).Text = $"Correct: {learnCorrect}/{learnSet.flashcards.Count} ({percentage}%)";
                renderPage(learnResultsUC);
            } else {
                //Render Next Question
                ((TextBox)learnQuestionUC.Controls.Find("txtProgress", false).FirstOrDefault()).Text = $"Q {learnProgress + 1}/{learnSet.flashcards.Count}";
                ((TextBox)learnQuestionUC.Controls.Find("txtScore", false).FirstOrDefault()).Text = $"Correct: {learnCorrect}/{learnProgress}";
                ((TextBox)learnQuestionUC.Controls.Find("txtQuestion", false).FirstOrDefault()).Text = learnSet.flashcards[learnProgress].question;
                ((TextBox)learnQuestionUC.Controls.Find("txtAnswer", false).FirstOrDefault()).Text = "";
                renderPage(learnQuestionUC);
            }
        }
        public void checkLearnQuestion(object sender, EventArgs e)
        {
            var userAnswer = ((TextBox)learnQuestionUC.Controls.Find("txtAnswer", false).FirstOrDefault()).Text;
            if (userAnswer != "")
            {
                ((TextBox)questionResultUC.Controls.Find("txtQuestion", false).FirstOrDefault()).Text = learnSet.flashcards[learnProgress].question;
                ((TextBox)questionResultUC.Controls.Find("txtProgress", false).FirstOrDefault()).Text = $"Q {learnProgress + 1}/{learnSet.flashcards.Count}";
                ((TextBox)questionResultUC.Controls.Find("txtUserAnswer", false).FirstOrDefault()).Text = $"Your Answer: {userAnswer}";
                ((TextBox)questionResultUC.Controls.Find("txtCorrectAnswer", false).FirstOrDefault()).Text = $"Correct Answer: {learnSet.flashcards[learnProgress].answer}";
                var txtResult = (TextBox)questionResultUC.Controls.Find("txtResult", false).FirstOrDefault();
                //Check Response
                bool correct = userAnswer == learnSet.flashcards[learnProgress].answer;
                if (correct)
                {
                    learnCorrect++;
                    txtResult.Text = "Correct!";
                } else {
                    txtResult.Text = "Incorrect";
                }
                ((TextBox)questionResultUC.Controls.Find("txtScore", false).FirstOrDefault()).Text = $"Correct: {learnCorrect}/{learnProgress + 1}";
                learnProgress++;
                renderPage(questionResultUC);
            }
        }
        public void learnStart(object sender, EventArgs e) {
            //Reset Global Variables
            learnProgress = 0;
            learnCorrect = 0;
            learnSet = new FlashcardSet { };
            //Find List Item
            var listView = (ListView)learnMenuUC.Controls.Find("listView", false).FirstOrDefault();
            if (listView.SelectedItems.Count == 1)
            {
                var setID = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);
                //Fetch Set from DB
                using (var db = new LiteDatabase(@"flashies.db"))
                {
                    var sets = db.GetCollection<FlashcardSet>("sets");
                    learnSet = sets.FindById(setID);
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
                    ((TextBox)learnQuestionUC.Controls.Find("txtTitle", false).FirstOrDefault()).Text = learnSet.name;
                    ((TextBox)questionResultUC.Controls.Find("txtTitle", false).FirstOrDefault()).Text = learnSet.name;
                    //Render Learn Question
                    renderLearnQuestion(this, e);
                }

            }
        }
        public void exit(object sender, EventArgs e)
        {
            renderPage(mainMenuUC);
        }
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
        public void setDelete(object sender, EventArgs e)
        {
            //Find List Item
            var listView = (ListView)createMenuUC.Controls.Find("listView", false).FirstOrDefault();
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
        public void menuCreate(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            renderSets((ListView)createMenuUC.Controls.Find("listView", false).FirstOrDefault());
            renderPage(createMenuUC);
        }
        public void createDetails(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            createSet = new FlashcardSet { };
            renderPage(createDetailsUC);
        }
        public void menuLearn(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            renderSets((ListView)learnMenuUC.Controls.Find("listView", false).FirstOrDefault());
            //Render Learn Page
            renderPage(learnMenuUC);
            //Database Testing
            /*using (var db = new LiteDatabase(@"flashies.db"))
            {
                var sets = db.GetCollection<FlashcardSet>("sets");
                var flashcard = new Flashcard
                {
                    question = "What is the first element of the periodic table?",
                    answer = "Hydrogen"
                };
                var set = new FlashcardSet
                {
                    timestamp = DateTimeOffset.Now.ToUnixTimeSeconds(),
                    name = "Test Set 4",
                    description = "A set for testing",
                    flashcards = new List<Flashcard> { flashcard }
                };
                sets.Insert(set);
                Console.WriteLine("Hello?");
                var results = sets.Find(x => x.name == "Test Set 4");
                foreach (var c in results) {
                    Console.WriteLine(c.description);
                    Console.WriteLine(c.flashcards);
                }
                //Delete All
                //sets.Delete(Query.All());
            }*/
        }
    }
}
