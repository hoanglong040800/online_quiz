namespace OnlineQuiz
{
    partial class launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(launcher));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Chonburi", 14F);
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Quiz Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_server
            // 
            this.btn_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_server.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_server.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_server.Location = new System.Drawing.Point(34, 125);
            this.btn_server.MaximumSize = new System.Drawing.Size(108, 35);
            this.btn_server.MinimumSize = new System.Drawing.Size(108, 35);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(108, 35);
            this.btn_server.TabIndex = 11;
            this.btn_server.Text = "Server";
            this.btn_server.UseVisualStyleBackColor = false;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_client.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_client.Location = new System.Drawing.Point(34, 196);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(108, 35);
            this.btn_client.TabIndex = 12;
            this.btn_client.Text = "Client";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(174, 261);
            this.Controls.Add(this.btn_client);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(190, 300);
            this.MinimumSize = new System.Drawing.Size(190, 300);
            this.Name = "launcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_client;
    }
}