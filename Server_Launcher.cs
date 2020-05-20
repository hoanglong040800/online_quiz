using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace OnlineQuiz
{
    public partial class server_launcher : Form
    {
        public server_launcher()
        {
            InitializeComponent();
            (new Thread(ServerListen)).Start();
        }

        // Server lắng nghe
        private void ServerListen()
        {
            try
            {
                TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
                tcpListener.Start();

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    (new Thread(ServerProcess)).Start(tcpClient);
                }
            }

            catch {}
        }

        // Điều hướng xử lí cho Server
        private void ServerProcess(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());
            sw.AutoFlush = true;

            if (sr.ReadLine() == "LOGIN")
            { 
                LoginCheck(sr, sw);
                return;
            }
        }

        // Kiểm tra thông tin Login
        private void LoginCheck(StreamReader sr, StreamWriter sw)
        {
            string strSignal      = "";
            string strStuID       = sr.ReadLine();
            string strQuizID      = sr.ReadLine();

            //Kiểm tra thông tin login
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;
                SqlDataReader reader;

                // Tìm kiếm StuID
                cmd = new SqlCommand("select StuID from STUDENT where StuID = @StuID ", sqlConnection);
                cmd.Parameters.AddWithValue("@StuID", strStuID);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                    strSignal = "FOUND";

                else
                {
                    sw.WriteLine("LOGIN FAIL");
                    return;
                }
                
                // Tìm kiếm QuizID
                reader.Close();
                cmd = new SqlCommand("select QuizID from QUIZ where QuizID = @QuizID ", sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID", strQuizID);
                reader = cmd.ExecuteReader();

                if (reader.Read() && strSignal == "FOUND") { }

                else
                {
                    sw.WriteLine("LOGIN FAIL");
                    return;
                }

                sqlConnection.Close();
            }

            //Nhập thông tin thí sinh vào bảng Result
            InsertIntoResult(strStuID, strQuizID);
            sw.WriteLine("LOGIN SUCCESS");
        }

        private void InsertIntoResult(string strStuID, string strQuizID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("select StuID, QuizID from RESULT where StuID = @StuID and QuizID = @QuizID", sqlConnection);
                cmd.Parameters.AddWithValue("@StuID"  , strStuID);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                reader = cmd.ExecuteReader();

                //TH chưa có StuID và QuizID trong table Result
                if (!reader.Read())
                {
                    MessageBox.Show("Not Found");

                    cmd = new SqlCommand("insert into RESULT values ( @StuID , @QuizID , null ) ", sqlConnection);
                    cmd.Parameters.AddWithValue("@StuID", strStuID);
                    cmd.Parameters.AddWithValue("@QuizID", strQuizID);
                    cmd.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }
        
        private void ServerSend()
        {
            /*string strSQL_GetQuesAns = "select * from QUESTION QE join ANSWER A on A.QuesID = QE.QuesID where exists (select * from QUIZ_QUESTION where QuizID = 'QZ01')";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Program.connectionString))
            {
                var questionDictionary = new Dictionary<string, QuesAns>();

                var list = connection.Query<QuesAns, Ans, QuesAns>(
                    strSQL_GetQuesAns,
                    (question, answer) =>
                    {
                        QuesAns questionEntry;
                        if (!questionDictionary.TryGetValue(question.QuesID, out questionEntry))
                        {
                            questionEntry = question;
                            questionEntry.Answers = new List<Ans>();
                            questionDictionary.Add(questionEntry.QuesID, question);
                        }
                        questionEntry.Answers.Add(answer);
                        return questionEntry;
                    },
                    splitOn: "AnsID"
                ).Distinct().ToList();
                // --- end of var list = connection.Query ---

                liQuesAns = list;
            }
            Update();*/
        }

        private void Update()
        {
            //lbQuestion.DataSource = liQuesAns;
            //lbQuestion.DisplayMember = "FullInfo";
        }

        private void btn_quizresult_Click(object sender, EventArgs e)
        {
            (new server_result()).Show();

        }
    }
}
