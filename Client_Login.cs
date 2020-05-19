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
            if (sr.ReadLine() == "LOGIN SUCCESS")
            {
                MessageBox.Show("Đăng nhập thành công");
                sr.Close();
                cli.CloseConnection();
                return true;
            }

            else
            {
                MessageBox.Show("Tham gia Quiz thất bại! Vui lòng kiểm tra lại MSSV và Mã code quiz");
                cli.CloseConnection();
                return false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string strStuID = tb_StuID.Text.Trim();
            string strQuizID = tb_QuizID.Text.Trim();
            StreamReader sr = new StreamReader(cli.ns);
            StreamWriter sw = new StreamWriter(cli.ns);

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
                Close();
            }
        }
    }
}
