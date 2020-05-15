namespace OnlineQuiz
{
    partial class server_resultlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(server_resultlist));
            this.dgv_result = new System.Windows.Forms.DataGridView();
            this.pb_uit = new System.Windows.Forms.PictureBox();
            this.lb_OnlineQuiz = new System.Windows.Forms.Label();
            this.lb_studentID = new System.Windows.Forms.Label();
            this.tb_studentID = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_result
            // 
            this.dgv_result.AllowUserToAddRows = false;
            this.dgv_result.AllowUserToDeleteRows = false;
            this.dgv_result.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Chonburi", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_result.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_result.Location = new System.Drawing.Point(19, 163);
            this.dgv_result.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_result.Name = "dgv_result";
            this.dgv_result.ReadOnly = true;
            this.dgv_result.Size = new System.Drawing.Size(696, 279);
            this.dgv_result.TabIndex = 0;
            // 
            // pb_uit
            // 
            this.pb_uit.BackColor = System.Drawing.Color.Transparent;
            this.pb_uit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_uit.Image = ((System.Drawing.Image)(resources.GetObject("pb_uit.Image")));
            this.pb_uit.Location = new System.Drawing.Point(19, 24);
            this.pb_uit.Name = "pb_uit";
            this.pb_uit.Size = new System.Drawing.Size(50, 50);
            this.pb_uit.TabIndex = 25;
            this.pb_uit.TabStop = false;
            // 
            // lb_OnlineQuiz
            // 
            this.lb_OnlineQuiz.AutoSize = true;
            this.lb_OnlineQuiz.BackColor = System.Drawing.Color.Transparent;
            this.lb_OnlineQuiz.Font = new System.Drawing.Font("Chonburi", 25F);
            this.lb_OnlineQuiz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lb_OnlineQuiz.Location = new System.Drawing.Point(72, 34);
            this.lb_OnlineQuiz.Margin = new System.Windows.Forms.Padding(0);
            this.lb_OnlineQuiz.Name = "lb_OnlineQuiz";
            this.lb_OnlineQuiz.Size = new System.Drawing.Size(239, 40);
            this.lb_OnlineQuiz.TabIndex = 26;
            this.lb_OnlineQuiz.Text = "Online Quiz";
            // 
            // lb_studentID
            // 
            this.lb_studentID.AutoSize = true;
            this.lb_studentID.BackColor = System.Drawing.Color.Transparent;
            this.lb_studentID.Font = new System.Drawing.Font("Chonburi", 10F);
            this.lb_studentID.Location = new System.Drawing.Point(16, 128);
            this.lb_studentID.Name = "lb_studentID";
            this.lb_studentID.Size = new System.Drawing.Size(109, 17);
            this.lb_studentID.TabIndex = 27;
            this.lb_studentID.Text = "Input Quiz ID";
            // 
            // tb_studentID
            // 
            this.tb_studentID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_studentID.BackColor = System.Drawing.Color.White;
            this.tb_studentID.Font = new System.Drawing.Font("Chonburi", 10F);
            this.tb_studentID.Location = new System.Drawing.Point(138, 125);
            this.tb_studentID.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.tb_studentID.Name = "tb_studentID";
            this.tb_studentID.Size = new System.Drawing.Size(109, 23);
            this.tb_studentID.TabIndex = 28;
            this.tb_studentID.Text = "uHd0N2";
            this.tb_studentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_filter
            // 
            this.btn_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filter.Font = new System.Drawing.Font("Chonburi", 10F);
            this.btn_filter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filter.Location = new System.Drawing.Point(260, 122);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(72, 26);
            this.btn_filter.TabIndex = 29;
            this.btn_filter.Text = "Lọc";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // server_resultlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.lb_studentID);
            this.Controls.Add(this.tb_studentID);
            this.Controls.Add(this.lb_OnlineQuiz);
            this.Controls.Add(this.pb_uit);
            this.Controls.Add(this.dgv_result);
            this.Name = "server_resultlist";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_uit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_result;
        private System.Windows.Forms.PictureBox pb_uit;
        private System.Windows.Forms.Label lb_OnlineQuiz;
        private System.Windows.Forms.Label lb_studentID;
        private System.Windows.Forms.TextBox tb_studentID;
        private System.Windows.Forms.Button btn_filter;
    }
}