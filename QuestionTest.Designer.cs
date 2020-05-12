namespace OnlineQuiz
{
    partial class QuestionTest
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
            this.lbQuestion = new System.Windows.Forms.ListBox();
            this.btnShowQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbQuestion
            // 
            this.lbQuestion.FormattingEnabled = true;
            this.lbQuestion.Location = new System.Drawing.Point(3, 103);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(793, 342);
            this.lbQuestion.TabIndex = 0;
            // 
            // btnShowQuestion
            // 
            this.btnShowQuestion.Location = new System.Drawing.Point(12, 29);
            this.btnShowQuestion.Name = "btnShowQuestion";
            this.btnShowQuestion.Size = new System.Drawing.Size(89, 46);
            this.btnShowQuestion.TabIndex = 1;
            this.btnShowQuestion.Text = "GET QUES";
            this.btnShowQuestion.UseVisualStyleBackColor = true;
            this.btnShowQuestion.Click += new System.EventHandler(this.btnShowQuestion_Click);
            // 
            // QuestionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowQuestion);
            this.Controls.Add(this.lbQuestion);
            this.Name = "QuestionTest";
            this.Text = "QuestionTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbQuestion;
        private System.Windows.Forms.Button btnShowQuestion;
    }
}