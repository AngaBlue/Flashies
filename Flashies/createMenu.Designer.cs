namespace Flashies
{
    partial class createMenu
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
            this.createMenuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createMenuTitle
            // 
            this.createMenuTitle.AutoSize = true;
            this.createMenuTitle.Location = new System.Drawing.Point(4, 4);
            this.createMenuTitle.Name = "createMenuTitle";
            this.createMenuTitle.Size = new System.Drawing.Size(57, 20);
            this.createMenuTitle.TabIndex = 0;
            this.createMenuTitle.Text = "Create";
            // 
            // createMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createMenuTitle);
            this.Name = "createMenu";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createMenuTitle;
    }
}
