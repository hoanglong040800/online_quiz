namespace OnlineQuiz
{
    partial class client_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(client_login));
            this.lb_studentID = new System.Windows.Forms.Label();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.lb_code = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_uit = new System.Windows.Forms.PictureBox();
            this.lb_OnlineQuiz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_studentID
            // 
            this.lb_studentID.AutoSize = true;
            this.lb_studentID.BackColor = System.Drawing.Color.Transparent;
            this.lb_studentID.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb_studentID.Location = new System.Drawing.Point(159, 211);
            this.lb_studentID.Name = "lb_studentID";
            this.lb_studentID.Size = new System.Drawing.Size(24, 17);
            this.lb_studentID.TabIndex = 4;
            this.lb_studentID.Text = "ID";
            // 
            // tb_studentID
            // 
            this.tb_studentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_studentID.BackColor = System.Drawing.Color.White;
            this.tb_studentID.Font = new System.Drawing.Font("Chonburi", 10F);
            this.tb_studentID.Location = new System.Drawing.Point(71, 236);
            this.tb_studentID.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(200, 23);
            this.tb_studentID.TabIndex = 8;
            this.tb_studentID.Text = "18520093";
            this.tb_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_code
            // 
            this.lb_code.AutoSize = true;
            this.lb_code.BackColor = System.Drawing.Color.Transparent;
            this.lb_code.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb_code.Location = new System.Drawing.Point(116, 292);
            this.lb_code.Name = "lb_code";
            this.lb_code.Size = new System.Drawing.Size(111, 17);
            this.lb_code.TabIndex = 7;
            this.lb_code.Text = "Mã Code quiz";
            // 
            // tb_code
            // 
            this.tb_code.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_code.BackColor = System.Drawing.Color.White;
            this.tb_code.Font = new System.Drawing.Font("Chonburi", 10F);
            this.tb_code.Location = new System.Drawing.Point(71, 317);
            this.tb_code.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(200, 23);
            this.tb_code.TabIndex = 9;
            this.tb_code.Text = "uHd0N2";
            this.tb_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_start.TabIndex = 10;
            this.btn_start.Text = "Vào Quiz";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_uit
            // 
            this.pb_uit.BackColor = System.Drawing.Color.Transparent;
            this.pb_uit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_uit.Image = ((System.Drawing.Image)(resources.GetObject("pb_uit.Image")));
            this.pb_uit.Location = new System.Drawing.Point(146, 30);
            this.pb_uit.Name = "pb_uit";
            this.pb_uit.Size = new System.Drawing.Size(50, 50);
            this.pb_uit.TabIndex = 24;
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
            this.lb_OnlineQuiz.TabIndex = 23;
            this.lb_OnlineQuiz.Text = "Online Quiz";
            // 
            // client_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 501);
            this.Controls.Add(this.lb_studentID);
            this.Controls.Add(this.pb_uit);
            this.Controls.Add(this.lb_OnlineQuiz);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.tb_studentID);
            this.Controls.Add(this.lb_code);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(20, 50);
            this.MaximumSize = new System.Drawing.Size(360, 540);
            this.MinimumSize = new System.Drawing.Size(360, 540);
            this.Name = "client_login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_studentID;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.Label lb_code;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pb_uit;
        private System.Windows.Forms.Label lb_OnlineQuiz;
    }
}