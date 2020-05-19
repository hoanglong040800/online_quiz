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
using System.Runtime.Serialization.Formatters.Binary;

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
            NetworkStream ns = tcpClient.GetStream();
            sw.AutoFlush = true;

            if (sr.ReadLine() == "LOGIN")
            {
                if (LoginCheck(sr, sw))
                {
                    string strQuizID = "";
                    SendQuizInfor(sr, ns, out strQuizID);
                    SendListQuesAns(sr, ns, strQuizID);
                    sr.Close();
                    sw.Close();
                    ns.Close();
                    tcpClient.Close();
                }

                return;
            }
        }

        // Kiểm tra thông tin Login
        private bool LoginCheck(StreamReader sr, StreamWriter sw)
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
                    return false;
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
                    return false;
                }

                sqlConnection.Close();
            }

            //Nhập thông tin thí sinh vào bảng Result
            InsertIntoResult(strStuID, strQuizID);
            sw.WriteLine("LOGIN SUCCESS");
            return true;
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

        private void SendQuizInfor(StreamReader sr, NetworkStream ns, out string strQuizID)
        {
            while (true)
            {
                strQuizID = sr.ReadLine();
                if (strQuizID != "")
                {
                    Quiz quiz = new Quiz();
                    string strSQL_GetQuiz = $"select * from QUIZ where QuizID = '{strQuizID}' "; // strQuizID
                    using (IDbConnection connection = new SqlConnection(Program.connectionString))
                    {
                        quiz = connection.QuerySingle<Quiz>(strSQL_GetQuiz);
                    }
                    MessageBox.Show(quiz.QuizID);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ns, quiz);
                    ns.Flush();
                    break;
                }
                else MessageBox.Show("error");
            }


        }

        private void SendListQuesAns(StreamReader sr, NetworkStream ns, string QuizID)
        {
            string strSignal = "";
            while (true)
            {
                strSignal = sr.ReadLine();
                if (strSignal == "QUESANS")
                {
                    List<QuesAns> liQuesAns = new List<QuesAns>();
                    string strSQL_GetQuesAns = $"select * from QUESTION QE join ANSWER A on A.QuesID = QE.QuesID where exists (select * from QUIZ_QUESTION where QuizID = '{QuizID}')";
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
                        liQuesAns = list;
                    }// --- end of var list = connection.Query ---

                    MessageBox.Show(liQuesAns[0].ToString());
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ns, liQuesAns);
                    ns.Flush();
                    break;
                }// end if

            } //end While

        }

        private void btn_quizresult_Click(object sender, EventArgs e)
        {
            (new server_resultlist()).Show();

        }
    }
}
