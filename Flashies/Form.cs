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
            public Guid id { get; set; }
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
            //Render Main Menu
            renderPage(mainMenuUC);

            //Init a Testing Set
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
                    name = "Test Set 7",
                    description = "A set for testing",
                    flashcards = new List<Flashcard> { flashcard }
                };
                sets.Insert(set);
            }*/
        }
        public void exit(object sender, EventArgs e)
        {
            renderPage(mainMenuUC);
        }
        public void menuCreate(object sender, EventArgs e)
        {
            renderPage(createMenuUC);
        }
        public void menuLearn(object sender, EventArgs e)
        {
            //Display All Flashcard Sets in DB
            var listView = (ListView)learnMenuUC.Controls.Find("listView", false).FirstOrDefault();
            using (var db = new LiteDatabase(@"flashies.db"))
            {
                var sets = db.GetCollection<FlashcardSet>("sets");
                var flashcardSets = sets.Find(Query.All("timestamp", Query.Ascending));
                listView.Items.Clear();
                foreach (FlashcardSet set in flashcardSets)
                {
                    listView.Items.Add(new ListViewItem(new[] { set.name, set.description }));
                };
            };
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
