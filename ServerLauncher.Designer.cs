namespace OnlineQuiz
{
    partial class server_launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server_launcher));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quizresult = new System.Windows.Forms.Button();
            this.btn_addquiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chonburi", 14F);
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_quizresult
            // 
            this.btn_quizresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_quizresult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quizresult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quizresult.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_quizresult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_quizresult.Location = new System.Drawing.Point(33, 194);
            this.btn_quizresult.Name = "btn_quizresult";
            this.btn_quizresult.Size = new System.Drawing.Size(108, 35);
            this.btn_quizresult.TabIndex = 12;
            this.btn_quizresult.Text = "Quiz Result";
            this.btn_quizresult.UseVisualStyleBackColor = false;
            this.btn_quizresult.Click += new System.EventHandler(this.btn_quizresult_Click);
            // 
            // btn_addquiz
            // 
            this.btn_addquiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_addquiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addquiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addquiz.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_addquiz.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addquiz.Location = new System.Drawing.Point(33, 121);
            this.btn_addquiz.Name = "btn_addquiz";
            this.btn_addquiz.Size = new System.Drawing.Size(108, 35);
            this.btn_addquiz.TabIndex = 13;
            this.btn_addquiz.Text = "Add quiz";
            this.btn_addquiz.UseVisualStyleBackColor = false;
            // 
            // server_launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(174, 261);
            this.Controls.Add(this.btn_addquiz);
            this.Controls.Add(this.btn_quizresult);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(0, 290);
            this.MaximumSize = new System.Drawing.Size(190, 300);
            this.MinimumSize = new System.Drawing.Size(190, 300);
            this.Name = "server_launcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quizresult;
        private System.Windows.Forms.Button btn_addquiz;
    }
}