using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashies
{
    public partial class mainMenu : UserControl
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void mainMenuCreate_Click(object sender, EventArgs e)
        {
            this.mainMenuCreate.Click += new System.EventHandler(((Form)this.Parent).mainMenuCreate_Click);
        }
    }
}