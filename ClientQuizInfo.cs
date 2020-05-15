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
           tcpClient.Connect("127.0.0.1", 8080);
          // StreamWriter sw = new StreamWriter(client_login.tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());
            sw.WriteLine("Đã mở Quiz Info");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            (new client_quiz()).Show();
            Close();
        }
    }
}
