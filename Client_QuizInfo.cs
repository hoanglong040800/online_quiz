using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace OnlineQuiz
{
    public partial class client_quizinfo : Form
    {
        //Truyền dữ liệu tham chiếu từ client_login
        public client_quizinfo()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            (new client_quiz()).Show();
            Close();
        }
    }
}
