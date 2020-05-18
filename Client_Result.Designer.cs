namespace OnlineQuiz

{

    partial class client_result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_result));
            this.btn_exit = new System.Windows.Forms.Button();
            this.gb_result = new System.Windows.Forms.GroupBox();
            this.lb_Score = new System.Windows.Forms.Label();
            this.lb_CorrectAnswer = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.pb_uit = new System.Windows.Forms.PictureBox();
            this.lb_OnlineQuiz = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.gb_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(117, 420);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(108, 35);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // gb_result
            // 
            this.gb_result.BackColor = System.Drawing.Color.Transparent;
            this.gb_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gb_result.Controls.Add(this.lb_Score);
            this.gb_result.Controls.Add(this.lb_CorrectAnswer);
            this.gb_result.Controls.Add(this.lb2);
            this.gb_result.Controls.Add(this.lb1);
            this.gb_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_result.Font = new System.Drawing.Font("Chonburi", 12F);
            this.gb_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gb_result.Location = new System.Drawing.Point(47, 279);
            this.gb_result.Name = "gb_result";
            this.gb_result.Size = new System.Drawing.Size(248, 96);
            this.gb_result.TabIndex = 35;
            this.gb_result.TabStop = false;
            this.gb_result.Text = "Kết Quả";
            // 
            // lb_Score
            // 
            this.lb_Score.AutoSize = true;
            this.lb_Score.Font = new System.Drawing.Font("Chonburi", 9.5F);
            this.lb_Score.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_Score.Location = new System.Drawing.Point(151, 65);
            this.lb_Score.Name = "lb_Score";
            this.lb_Score.Size = new System.Drawing.Size(24, 15);
            this.lb_Score.TabIndex = 43;
            this.lb_Score.Text = "10";
            // 
            // lb_CorrectAnswer
            // 
            this.lb_CorrectAnswer.AutoSize = true;
            this.lb_CorrectAnswer.Font = new System.Drawing.Font("Chonburi", 9.5F);
            this.lb_CorrectAnswer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_CorrectAnswer.Location = new System.Drawing.Point(151, 36);
            this.lb_CorrectAnswer.Name = "lb_CorrectAnswer";
            this.lb_CorrectAnswer.Size = new System.Drawing.Size(49, 15);
            this.lb_CorrectAnswer.TabIndex = 42;
            this.lb_CorrectAnswer.Text = "20/20";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb2.Location = new System.Drawing.Point(71, 63);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(74, 17);
            this.lb2.TabIndex = 41;
            this.lb2.Text = "Số điểm:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb1.Location = new System.Drawing.Point(37, 36);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(108, 17);
            this.lb1.TabIndex = 40;
            this.lb1.Text = "Số câu đúng:";
            // 
            // pb_uit
            // 
            this.pb_uit.BackColor = System.Drawing.Color.Transparent;
            this.pb_uit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_uit.Image = ((System.Drawing.Image)(resources.GetObject("pb_uit.Image")));
            this.pb_uit.Location = new System.Drawing.Point(146, 30);
            this.pb_uit.Name = "pb_uit";
            this.pb_uit.Size = new System.Drawing.Size(50, 50);
            this.pb_uit.TabIndex = 37;
            this.pb_uit.TabStop = false;
            // 
            // lb_OnlineQuiz
            // 
            this.lb_OnlineQuiz.AutoSize = true;
            this.lb_OnlineQuiz.BackColor = System.Drawing.Color.Transparent;
            this.lb_OnlineQuiz.Font = new System.Drawing.Font("Chonburi", 25F);
            this.lb_OnlineQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_OnlineQuiz.Location = new System.Drawing.Point(52, 100);
            this.lb_OnlineQuiz.Margin = new System.Windows.Forms.Padding(0);
            this.lb_OnlineQuiz.Name = "lb_OnlineQuiz";
            this.lb_OnlineQuiz.Size = new System.Drawing.Size(239, 40);
            this.lb_OnlineQuiz.TabIndex = 36;
            this.lb_OnlineQuiz.Text = "Online Quiz";
            this.lb_OnlineQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Chonburi", 12F);
            this.lb_title.Location = new System.Drawing.Point(0, 171);
            this.lb_title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(342, 50);
            this.lb_title.TabIndex = 38;
            this.lb_title.Text = "Kiểm tra cuối kì";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb_time.Location = new System.Drawing.Point(0, 223);
            this.lb_time.Margin = new System.Windows.Forms.Padding(0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(342, 24);
            this.lb_time.TabIndex = 39;
            this.lb_time.Text = "Thời gian: 120 phút";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // client_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_uit);
            this.Controls.Add(this.lb_OnlineQuiz);
            this.Controls.Add(this.gb_result);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "client_result";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gb_result.ResumeLayout(false);
            this.gb_result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox gb_result;
        private System.Windows.Forms.PictureBox pb_uit;
        private System.Windows.Forms.Label lb_OnlineQuiz;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.Label lb_CorrectAnswer;
    }
}