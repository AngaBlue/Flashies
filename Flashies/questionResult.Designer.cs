namespace Flashies
{
    partial class questionResult
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtUserAnswer = new System.Windows.Forms.TextBox();
            this.txtCorrectAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.txtTitle.TabIndex = 16;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtProgress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProgress.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgress.Location = new System.Drawing.Point(692, 20);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.Size = new System.Drawing.Size(181, 37);
            this.txtProgress.TabIndex = 15;
            this.txtProgress.TabStop = false;
            this.txtProgress.Text = "-/-";
            this.txtProgress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtScore
            // 
            this.txtScore.BackColor = System.Drawing.SystemColors.Menu;
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(593, 534);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(280, 37);
            this.txtScore.TabIndex = 14;
            this.txtScore.TabStop = false;
            this.txtScore.Text = "Correct: 0/0";
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(25, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(123, 113);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(649, 55);
            this.txtResult.TabIndex = 17;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "Result";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserAnswer
            // 
            this.txtUserAnswer.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUserAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserAnswer.Location = new System.Drawing.Point(123, 349);
            this.txtUserAnswer.Name = "txtUserAnswer";
            this.txtUserAnswer.ReadOnly = true;
            this.txtUserAnswer.Size = new System.Drawing.Size(649, 37);
            this.txtUserAnswer.TabIndex = 18;
            this.txtUserAnswer.TabStop = false;
            this.txtUserAnswer.Text = "Your Answer:";
            this.txtUserAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorrectAnswer
            // 
            this.txtCorrectAnswer.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorrectAnswer.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAnswer.Location = new System.Drawing.Point(123, 392);
            this.txtCorrectAnswer.Name = "txtCorrectAnswer";
            this.txtCorrectAnswer.ReadOnly = true;
            this.txtCorrectAnswer.Size = new System.Drawing.Size(649, 37);
            this.txtCorrectAnswer.TabIndex = 19;
            this.txtCorrectAnswer.TabStop = false;
            this.txtCorrectAnswer.Text = "Correct Answer:";
            this.txtCorrectAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(95, 187);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(711, 130);
            this.txtQuestion.TabIndex = 20;
            this.txtQuestion.TabStop = false;
            this.txtQuestion.Text = "Question";
            this.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(388, 466);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(117, 50);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // questionResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtCorrectAnswer);
            this.Controls.Add(this.txtUserAnswer);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnExit);
            this.Name = "questionResult";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtUserAnswer;
        private System.Windows.Forms.TextBox txtCorrectAnswer;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnContinue;
    }
}
