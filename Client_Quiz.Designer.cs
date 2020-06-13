namespace OnlineQuiz
{
    partial class client_quiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_quiz));
            this.lb_ques = new System.Windows.Forms.Label();
            this.lb_numsOfQues = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.pb_ques = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tb_curPage = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_countdown = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rb_ans1 = new System.Windows.Forms.RadioButton();
            this.rb_ans2 = new System.Windows.Forms.RadioButton();
            this.rb_ans3 = new System.Windows.Forms.RadioButton();
            this.rb_ans4 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ques)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_ques
            // 
            this.lb_ques.BackColor = System.Drawing.Color.Transparent;
            this.lb_ques.Font = new System.Drawing.Font("Verdana", 12F);
            this.lb_ques.Location = new System.Drawing.Point(42, 91);
            this.lb_ques.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lb_ques.Name = "lb_ques";
            this.lb_ques.Size = new System.Drawing.Size(543, 189);
            this.lb_ques.TabIndex = 27;
            this.lb_ques.Text = "Which network design may be recommended for a small campus site that consists of " +
    "a single building with a few users?";
            // 
            // lb_numsOfQues
            // 
            this.lb_numsOfQues.AutoSize = true;
            this.lb_numsOfQues.BackColor = System.Drawing.Color.Transparent;
            this.lb_numsOfQues.Font = new System.Drawing.Font("Chonburi", 12F);
            this.lb_numsOfQues.Location = new System.Drawing.Point(180, 43);
            this.lb_numsOfQues.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_numsOfQues.Name = "lb_numsOfQues";
            this.lb_numsOfQues.Size = new System.Drawing.Size(14, 19);
            this.lb_numsOfQues.TabIndex = 26;
            this.lb_numsOfQues.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chonburi", 14F);
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Câu hỏi:";
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_submit.FlatAppearance.BorderSize = 0;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submit.Location = new System.Drawing.Point(1034, 633);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(10);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(108, 35);
            this.btn_submit.TabIndex = 34;
            this.btn_submit.Text = "Hoàn tất";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // pb_ques
            // 
            this.pb_ques.BackColor = System.Drawing.Color.Transparent;
            this.pb_ques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ques.Location = new System.Drawing.Point(42, 254);
            this.pb_ques.Margin = new System.Windows.Forms.Padding(10);
            this.pb_ques.Name = "pb_ques";
            this.pb_ques.Size = new System.Drawing.Size(543, 338);
            this.pb_ques.TabIndex = 28;
            this.pb_ques.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrevious.Location = new System.Drawing.Point(652, 53);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(81, 26);
            this.btnPrevious.TabIndex = 41;
            this.btnPrevious.Text = "Trước";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Location = new System.Drawing.Point(753, 53);
            this.btnNext.Margin = new System.Windows.Forms.Padding(10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(81, 26);
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tb_curPage
            // 
            this.tb_curPage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_curPage.BackColor = System.Drawing.Color.White;
            this.tb_curPage.Font = new System.Drawing.Font("Chonburi", 10F);
            this.tb_curPage.Location = new System.Drawing.Point(145, 41);
            this.tb_curPage.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.tb_curPage.Name = "tb_curPage";
            this.tb_curPage.Size = new System.Drawing.Size(33, 23);
            this.tb_curPage.TabIndex = 43;
            this.tb_curPage.Text = "15";
            this.tb_curPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_curPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTest_KeyDown);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lb_countdown
            // 
            this.lb_countdown.AutoSize = true;
            this.lb_countdown.BackColor = System.Drawing.Color.Transparent;
            this.lb_countdown.Font = new System.Drawing.Font("Chonburi", 14F);
            this.lb_countdown.Location = new System.Drawing.Point(490, 40);
            this.lb_countdown.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_countdown.Name = "lb_countdown";
            this.lb_countdown.Size = new System.Drawing.Size(112, 23);
            this.lb_countdown.TabIndex = 44;
            this.lb_countdown.Text = "00:00:00";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(241, 38);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 26);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rb_ans1
            // 
            this.rb_ans1.BackColor = System.Drawing.Color.Transparent;
            this.rb_ans1.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_ans1.Location = new System.Drawing.Point(688, 127);
            this.rb_ans1.Name = "rb_ans1";
            this.rb_ans1.Size = new System.Drawing.Size(410, 104);
            this.rb_ans1.TabIndex = 47;
            this.rb_ans1.TabStop = true;
            this.rb_ans1.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.rb_ans1.UseVisualStyleBackColor = false;
            // 
            // rb_ans2
            // 
            this.rb_ans2.BackColor = System.Drawing.Color.Transparent;
            this.rb_ans2.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_ans2.Location = new System.Drawing.Point(688, 240);
            this.rb_ans2.Name = "rb_ans2";
            this.rb_ans2.Size = new System.Drawing.Size(410, 104);
            this.rb_ans2.TabIndex = 48;
            this.rb_ans2.TabStop = true;
            this.rb_ans2.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.rb_ans2.UseVisualStyleBackColor = false;
            // 
            // rb_ans3
            // 
            this.rb_ans3.BackColor = System.Drawing.Color.Transparent;
            this.rb_ans3.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_ans3.Location = new System.Drawing.Point(688, 350);
            this.rb_ans3.Name = "rb_ans3";
            this.rb_ans3.Size = new System.Drawing.Size(410, 104);
            this.rb_ans3.TabIndex = 49;
            this.rb_ans3.TabStop = true;
            this.rb_ans3.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.rb_ans3.UseVisualStyleBackColor = false;
            // 
            // rb_ans4
            // 
            this.rb_ans4.BackColor = System.Drawing.Color.Transparent;
            this.rb_ans4.Font = new System.Drawing.Font("Verdana", 10F);
            this.rb_ans4.Location = new System.Drawing.Point(688, 463);
            this.rb_ans4.Name = "rb_ans4";
            this.rb_ans4.Size = new System.Drawing.Size(410, 104);
            this.rb_ans4.TabIndex = 50;
            this.rb_ans4.TabStop = true;
            this.rb_ans4.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.rb_ans4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Chonburi", 11F);
            this.label2.Location = new System.Drawing.Point(191, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "/20";
            // 
            // client_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pb_ques);
            this.Controls.Add(this.lb_countdown);
            this.Controls.Add(this.tb_curPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lb_ques);
            this.Controls.Add(this.lb_numsOfQues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_ans1);
            this.Controls.Add(this.rb_ans2);
            this.Controls.Add(this.rb_ans3);
            this.Controls.Add(this.rb_ans4);
            this.MaximumSize = new System.Drawing.Size(1200, 726);
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "client_quiz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.Load += new System.EventHandler(this.client_quiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_ques;
        private System.Windows.Forms.Label lb_numsOfQues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.PictureBox pb_ques;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tb_curPage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_countdown;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rb_ans1;
        private System.Windows.Forms.RadioButton rb_ans2;
        private System.Windows.Forms.RadioButton rb_ans3;
        private System.Windows.Forms.RadioButton rb_ans4;
        private System.Windows.Forms.Label label2;
    }
}