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
            this.cb_ans1 = new System.Windows.Forms.CheckBox();
            this.cb_ans2 = new System.Windows.Forms.CheckBox();
            this.cb_ans3 = new System.Windows.Forms.CheckBox();
            this.cb_ans4 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_curPage = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lb_countdown = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.lb_numsOfQues.Size = new System.Drawing.Size(37, 19);
            this.lb_numsOfQues.TabIndex = 26;
            this.lb_numsOfQues.Text = "/20";
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
            this.pb_ques.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_ques.BackgroundImage")));
            this.pb_ques.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_ques.Location = new System.Drawing.Point(42, 254);
            this.pb_ques.Margin = new System.Windows.Forms.Padding(10);
            this.pb_ques.Name = "pb_ques";
            this.pb_ques.Size = new System.Drawing.Size(543, 338);
            this.pb_ques.TabIndex = 28;
            this.pb_ques.TabStop = false;
            // 
            // cb_ans1
            // 
            this.cb_ans1.BackColor = System.Drawing.Color.Transparent;
            this.cb_ans1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ans1.Font = new System.Drawing.Font("Verdana", 10F);
            this.cb_ans1.Location = new System.Drawing.Point(688, 141);
            this.cb_ans1.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.cb_ans1.Name = "cb_ans1";
            this.cb_ans1.Size = new System.Drawing.Size(422, 73);
            this.cb_ans1.TabIndex = 37;
            this.cb_ans1.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.cb_ans1.UseVisualStyleBackColor = false;
            // 
            // cb_ans2
            // 
            this.cb_ans2.BackColor = System.Drawing.Color.Transparent;
            this.cb_ans2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ans2.Font = new System.Drawing.Font("Verdana", 10F);
            this.cb_ans2.Location = new System.Drawing.Point(688, 254);
            this.cb_ans2.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.cb_ans2.Name = "cb_ans2";
            this.cb_ans2.Size = new System.Drawing.Size(422, 73);
            this.cb_ans2.TabIndex = 38;
            this.cb_ans2.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.cb_ans2.UseVisualStyleBackColor = false;
            // 
            // cb_ans3
            // 
            this.cb_ans3.BackColor = System.Drawing.Color.Transparent;
            this.cb_ans3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ans3.Font = new System.Drawing.Font("Verdana", 10F);
            this.cb_ans3.Location = new System.Drawing.Point(688, 367);
            this.cb_ans3.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.cb_ans3.Name = "cb_ans3";
            this.cb_ans3.Size = new System.Drawing.Size(422, 73);
            this.cb_ans3.TabIndex = 39;
            this.cb_ans3.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.cb_ans3.UseVisualStyleBackColor = false;
            // 
            // cb_ans4
            // 
            this.cb_ans4.BackColor = System.Drawing.Color.Transparent;
            this.cb_ans4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ans4.Font = new System.Drawing.Font("Verdana", 10F);
            this.cb_ans4.Location = new System.Drawing.Point(688, 480);
            this.cb_ans4.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.cb_ans4.Name = "cb_ans4";
            this.cb_ans4.Size = new System.Drawing.Size(422, 73);
            this.cb_ans4.TabIndex = 40;
            this.cb_ans4.Text = "A network design where the access and distribution layers are collapsed into a si" +
    "ngle layer.  A network design where the access and core layers are collapsed int" +
    "o a single layer";
            this.cb_ans4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Chonburi", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(652, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 41;
            this.button1.Text = "Trước";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Chonburi", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(753, 53);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 26);
            this.button2.TabIndex = 42;
            this.button2.Text = "Sau";
            this.button2.UseVisualStyleBackColor = false;
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
            this.lb_countdown.Click += new System.EventHandler(this.lb_countdown_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 45;
            // 
            // client_quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 687);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_countdown);
            this.Controls.Add(this.tb_curPage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_ans4);
            this.Controls.Add(this.cb_ans3);
            this.Controls.Add(this.cb_ans2);
            this.Controls.Add(this.cb_ans1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.pb_ques);
            this.Controls.Add(this.lb_ques);
            this.Controls.Add(this.lb_numsOfQues);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 726);
            this.MinimumSize = new System.Drawing.Size(1200, 726);
            this.Name = "client_quiz";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.CheckBox cb_ans1;
        private System.Windows.Forms.CheckBox cb_ans2;
        private System.Windows.Forms.CheckBox cb_ans3;
        private System.Windows.Forms.CheckBox cb_ans4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_curPage;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lb_countdown;
        private System.Windows.Forms.TextBox textBox1;
    }
}