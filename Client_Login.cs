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
    public partial class client_login : Form
    {
        Client cli=new Client();

        public client_login()
        {
            InitializeComponent();
        }

        private bool LoginListener(StreamReader sr)
        {         
            string strSignal = "";

            while (true)
            {
                strSignal = sr.ReadLine();
                if (strSignal == "LOGIN SUCCESS") break;
                MessageBox.Show("Tham gia Quiz thất bại! Vui lòng kiểm tra lại MSSV và Mã code quiz");
                cli.CloseConnection();
            }

            sr.Close();
            MessageBox.Show("Đăng nhập thành công");
            cli.CloseConnection();
            return true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string strStuID  = tb_StuID.Text.Trim();
            string strQuizID = tb_QuizID.Text.Trim();
            StreamReader sr = new StreamReader(cli.tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(cli.tcpClient.GetStream());

            if (strStuID == "" || strQuizID == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ MSSV và mã code quiz");
                return;
            }

            sw.WriteLine("LOGIN");
            sw.WriteLine(strStuID);
            sw.WriteLine(strQuizID);
            sw.Flush();


            if (LoginListener(sr) == true)
            {
                (new client_quizinfo()).Show();
                cli.CloseConnection();
                Close();
            }
        }
        
    }
}
