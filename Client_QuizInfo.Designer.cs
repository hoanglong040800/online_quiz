namespace OnlineQuiz
{
    partial class client_quizinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_quizinfo));
            this.pb_uit = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lb_OnlineQuiz = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_uit
            // 
            this.pb_uit.BackColor = System.Drawing.Color.Transparent;
            this.pb_uit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_uit.Image = ((System.Drawing.Image)(resources.GetObject("pb_uit.Image")));
            this.pb_uit.Location = new System.Drawing.Point(146, 30);
            this.pb_uit.Name = "pb_uit";
            this.pb_uit.Size = new System.Drawing.Size(50, 50);
            this.pb_uit.TabIndex = 22;
            this.pb_uit.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_start.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_start.Location = new System.Drawing.Point(117, 420);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(108, 35);
            this.btn_start.TabIndex = 21;
            this.btn_start.Text = "Bắt Đầu";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
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
            this.lb_OnlineQuiz.TabIndex = 14;
            this.lb_OnlineQuiz.Text = "Online Quiz";
            // 
            // lb_time
            // 
            this.lb_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_time.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb_time.Location = new System.Drawing.Point(0, 277);
            this.lb_time.Margin = new System.Windows.Forms.Padding(0);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(342, 24);
            this.lb_time.TabIndex = 41;
            this.lb_time.Text = "Thời gian: 120 phút";
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_title
            // 
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Chonburi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(0, 206);
            this.lb_title.Margin = new System.Windows.Forms.Padding(0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(342, 50);
            this.lb_title.TabIndex = 40;
            this.lb_title.Text = "Kiểm tra cuối kì";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // client_quizinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.pb_uit);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lb_OnlineQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "client_quizinfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_uit;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lb_OnlineQuiz;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_title;
    }
}