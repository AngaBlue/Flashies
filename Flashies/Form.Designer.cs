namespace Flashies
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createMenuUC = new Flashies.createMenu();
            this.mainMenuUC = new Flashies.mainMenu();
            this.learnMenuUC = new Flashies.learnMenu();
            this.SuspendLayout();
            // 
            // createMenuUC
            // 
            this.createMenuUC.Location = new System.Drawing.Point(-1, 1);
            this.createMenuUC.Name = "createMenuUC";
            this.createMenuUC.Size = new System.Drawing.Size(900, 600);
            this.createMenuUC.TabIndex = 1;
            // 
            // mainMenuUC
            // 
            this.mainMenuUC.Location = new System.Drawing.Point(-1, 1);
            this.mainMenuUC.Name = "mainMenuUC";
            this.mainMenuUC.Size = new System.Drawing.Size(900, 600);
            this.mainMenuUC.TabIndex = 0;
            // 
            // learnMenuUC
            // 
            this.learnMenuUC.Location = new System.Drawing.Point(-1, 1);
            this.learnMenuUC.Name = "learnMenuUC";
            this.learnMenuUC.Size = new System.Drawing.Size(900, 600);
            this.learnMenuUC.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.learnMenuUC);
            this.Controls.Add(this.createMenuUC);
            this.Controls.Add(this.mainMenuUC);
            this.Name = "Form";
            this.Text = "Flashies";
            this.ResumeLayout(false);

        }

        #endregion

        private mainMenu mainMenuUC;
        private createMenu createMenuUC;
        private learnMenu learnMenuUC;
    }
}

