namespace Flashies.Properties
{
    partial class learnResults
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.txtCorrect = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(388, 442);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(117, 47);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // txtCorrect
            // 
            this.txtCorrect.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCorrect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorrect.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrect.Location = new System.Drawing.Point(123, 288);
            this.txtCorrect.Name = "txtCorrect";
            this.txtCorrect.ReadOnly = true;
            this.txtCorrect.Size = new System.Drawing.Size(649, 37);
            this.txtCorrect.TabIndex = 27;
            this.txtCorrect.TabStop = false;
            this.txtCorrect.Text = "Correct:";
            this.txtCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(123, 172);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(649, 55);
            this.txtResults.TabIndex = 26;
            this.txtResults.TabStop = false;
            this.txtResults.Text = "Results";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(25, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(649, 37);
            this.txtTitle.TabIndex = 25;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            // 
            // learnResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtCorrect);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtTitle);
            this.Name = "learnResults";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtCorrect;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
