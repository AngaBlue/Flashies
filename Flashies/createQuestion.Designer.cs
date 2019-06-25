namespace Flashies
{
    partial class createQuestion
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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestionLabel = new System.Windows.Forms.TextBox();
            this.txtAnswerLabel = new System.Windows.Forms.TextBox();
            this.txtQuestionNumber = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(750, 540);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(129, 47);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next Question";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(570, 540);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(174, 47);
            this.btnFinish.TabIndex = 11;
            this.btnFinish.Text = "Create Last Question";
            this.btnFinish.UseVisualStyleBackColor = true;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(123, 217);
            this.txtQuestion.MaxLength = 128;
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(655, 86);
            this.txtQuestion.TabIndex = 24;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(123, 352);
            this.txtAnswer.MaxLength = 32;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(655, 30);
            this.txtAnswer.TabIndex = 23;
            // 
            // txtQuestionLabel
            // 
            this.txtQuestionLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQuestionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionLabel.Location = new System.Drawing.Point(0, 174);
            this.txtQuestionLabel.Name = "txtQuestionLabel";
            this.txtQuestionLabel.ReadOnly = true;
            this.txtQuestionLabel.Size = new System.Drawing.Size(900, 37);
            this.txtQuestionLabel.TabIndex = 21;
            this.txtQuestionLabel.TabStop = false;
            this.txtQuestionLabel.Text = "Question";
            this.txtQuestionLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnswerLabel
            // 
            this.txtAnswerLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswerLabel.Location = new System.Drawing.Point(0, 309);
            this.txtAnswerLabel.Name = "txtAnswerLabel";
            this.txtAnswerLabel.ReadOnly = true;
            this.txtAnswerLabel.Size = new System.Drawing.Size(900, 37);
            this.txtAnswerLabel.TabIndex = 25;
            this.txtAnswerLabel.TabStop = false;
            this.txtAnswerLabel.Text = "Answer";
            this.txtAnswerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQuestionNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionNumber.Location = new System.Drawing.Point(762, 14);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.ReadOnly = true;
            this.txtQuestionNumber.Size = new System.Drawing.Size(135, 37);
            this.txtQuestionNumber.TabIndex = 26;
            this.txtQuestionNumber.TabStop = false;
            this.txtQuestionNumber.Text = "Q -";
            this.txtQuestionNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(10, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(746, 37);
            this.txtTitle.TabIndex = 27;
            this.txtTitle.TabStop = false;
            this.txtTitle.Text = "Title";
            // 
            // createQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtQuestionNumber);
            this.Controls.Add(this.txtAnswerLabel);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtQuestionLabel);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Name = "createQuestion";
            this.Size = new System.Drawing.Size(900, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestionLabel;
        private System.Windows.Forms.TextBox txtAnswerLabel;
        private System.Windows.Forms.TextBox txtQuestionNumber;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
