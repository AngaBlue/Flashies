namespace Flashies
{
    partial class mainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.mainMenuLearn = new System.Windows.Forms.Button();
            this.mainMenuCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AutoSize = true;
            this.mainMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuTitle.Location = new System.Drawing.Point(287, 140);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(334, 91);
            this.mainMenuTitle.TabIndex = 0;
            this.mainMenuTitle.Text = "Flashies";
            // 
            // mainMenuLearn
            // 
            this.mainMenuLearn.Location = new System.Drawing.Point(112, 333);
            this.mainMenuLearn.Name = "mainMenuLearn";
            this.mainMenuLearn.Size = new System.Drawing.Size(273, 76);
            this.mainMenuLearn.TabIndex = 1;
            this.mainMenuLearn.Text = "Learn";
            this.mainMenuLearn.UseVisualStyleBackColor = true;
            // 
            // mainMenuCreate
            // 
            this.mainMenuCreate.Location = new System.Drawing.Point(515, 333);
            this.mainMenuCreate.Name = "mainMenuCreate";
            this.mainMenuCreate.Size = new System.Drawing.Size(273, 76);
            this.mainMenuCreate.TabIndex = 2;
            this.mainMenuCreate.Text = "Create";
            this.mainMenuCreate.UseVisualStyleBackColor = true;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenuCreate);
            this.Controls.Add(this.mainMenuLearn);
            this.Controls.Add(this.mainMenuTitle);
            this.Name = "mainMenu";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainMenuTitle;
        public System.Windows.Forms.Button mainMenuLearn;
        public System.Windows.Forms.Button mainMenuCreate;
    }
}
