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
        TcpClient tcpClient = new TcpClient();

        public client_quizinfo()
        {
            InitializeComponent();
            StreamWriter sw = new StreamWriter(client_login.tcpClient.GetStream());
            sw.WriteLine("Đã mở Quiz Info");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            (new client_quiz()).Show();
            Close();
        }
    }
}
