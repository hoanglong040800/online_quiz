using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OnlineQuiz
{
    public partial class client_login : Form
    {
        Client cli = new Client();
        public static Quiz quiz = new Quiz();
        public static List<QuesAns> liQuesAns = new List<QuesAns>();
        public static string strQuizIDGlobal;
        public static string strStuIDGlobal;
      
        public client_login()
        {
            InitializeComponent();
        }

        private bool LoginListener(StreamReader sr)
        {         
            if (sr.ReadLine() == "LOGIN SUCCESS")
            {
                MessageBox.Show("Đăng nhập thành công");
                return true;
            }

            else
            {
                MessageBox.Show("Tham gia Quiz thất bại! Vui lòng kiểm tra lại MSSV và Mã code quiz");
                return false;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string strStuID = tb_StuID.Text.Trim();
            strStuIDGlobal = strStuID;
            string strQuizID = tb_QuizID.Text.Trim();
            strQuizIDGlobal = strQuizID;
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

            if (LoginListener(sr))
            {
                //Gửi QuizID
                sw.WriteLine(strQuizID);
                sw.Flush();

                // Nhận QuizInfo
                BinaryFormatter bf = new BinaryFormatter();
                quiz = (Quiz)bf.Deserialize(cli.ns);


                // nhận list<QuesAns>
                sw.WriteLine("QUESANS");
                sw.Flush();
                BinaryFormatter bf1 = new BinaryFormatter();
                liQuesAns = (List<QuesAns>)bf1.Deserialize(cli.ns);
                cli.CloseConnection();

                (new client_quizinfo()).Show();
                Close();
            }
        }
    }
}
