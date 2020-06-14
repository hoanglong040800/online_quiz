using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    public partial class server_launcher:Form
    {
        public server_launcher ()
        {
            InitializeComponent();
            (new Thread(ServerListen)).Start();
        }

        // Server lắng nghe
        private void ServerListen ()
        {
            try
            {
                TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1") , 8080);
                tcpListener.Start();

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    (new Thread(ServerProcess)).Start(tcpClient);
                }
            }

            catch { }
        }

        // Điều hướng xử lí cho Server
        private void ServerProcess (object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());
            NetworkStream ns = tcpClient.GetStream();
            sw.AutoFlush = true;
            string strRequest = "";

            while (true)
            {
                strRequest = sr.ReadLine();
                if (strRequest == "LOGIN")
                {
                    if (LoginCheck(sr , sw))
                    {
                        string strQuizID = "";
                        SendQuizInfo(sr , ns , out strQuizID);
                        SendListQuesAns(sr , ns , strQuizID);
                        break;
                    }
                }

                else if (strRequest.StartsWith("SUBMIT"))
                {
                    //strRequest = SUBMIT: QuizID StrID
                    string[] identify = strRequest.Split(' ');
                    sw.WriteLine("CLIENTANS");

                    // Nhận liClientAns
                    BinaryFormatter bf = new BinaryFormatter();
                    List<ClientAns> liClientAns = (List<ClientAns>)bf.Deserialize(ns);

                    CheckAns(liClientAns , sw , identify[1] , identify[2]);
                    break;
                }
            }


            sr.Close();
            sw.Close();
            ns.Close();
            tcpClient.Close();
        }

        // Kiểm tra thông tin Login
        private bool LoginCheck (StreamReader sr , StreamWriter sw)
        {
            string strSignal = "";
            string strStuID = sr.ReadLine();
            string strQuizID = sr.ReadLine();

            //Kiểm tra thông tin login
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;
                SqlDataReader reader;

                // Tìm kiếm StuID
                cmd = new SqlCommand("select StuID from STUDENT where StuID = @StuID " , sqlConnection);
                cmd.Parameters.AddWithValue("@StuID" , strStuID);
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
                cmd = new SqlCommand("select QuizID from QUIZ where QuizID = @QuizID " , sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                reader = cmd.ExecuteReader();

                if (reader.Read() && strSignal == "FOUND")
                { }

                else
                {
                    sw.WriteLine("LOGIN FAIL");
                    return false;
                }

                sqlConnection.Close();
            }

            //Nhập thông tin thí sinh vào bảng Result
            InsertToResult(strStuID , strQuizID);
            sw.WriteLine("LOGIN SUCCESS");
            return true;
        }

        // Thêm thông tin user đang thực hiện quiz bảng result trước
        private void InsertToResult (string strStuID , string strQuizID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;
                SqlDataReader reader;

                cmd = new SqlCommand("select StuID, QuizID from RESULT where StuID = @StuID and QuizID = @QuizID" , sqlConnection);
                cmd.Parameters.AddWithValue("@StuID" , strStuID);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                reader = cmd.ExecuteReader();

                //TH chưa có StuID và QuizID trong table Result
                if (!reader.Read())
                {
                    MessageBox.Show("Not Found in Result");

                    cmd = new SqlCommand("insert into RESULT values ( @StuID , @QuizID , null ) " , sqlConnection);
                    cmd.Parameters.AddWithValue("@StuID" , strStuID);
                    cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                    cmd.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
        }

        // Gửi thông tin đề
        private void SendQuizInfo (StreamReader sr , NetworkStream ns , out string strQuizID)
        {
            while (true)
            {
                strQuizID = sr.ReadLine();
                if (strQuizID != "")
                {
                    Quiz quiz = new Quiz();
                    string strSQL_GetQuiz = $"select * from QUIZ where QuizID = '{strQuizID}' ";
                    using (IDbConnection connection = new SqlConnection(Program.connectionString))
                    {
                        quiz = connection.QuerySingle<Quiz>(strSQL_GetQuiz);
                    }

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ns , quiz);
                    ns.Flush();
                    break;
                }

                else MessageBox.Show("error");
            }
        }

        // Gửi bộ câu hỏi và câu trả lời
        private void SendListQuesAns (StreamReader sr , NetworkStream ns , string QuizID)
        {
            string strSignal = "";
            while (true)
            {
                strSignal = sr.ReadLine();
                if (strSignal == "QUESANS")
                {
                    List<QuesAns> liQuesAns = new List<QuesAns>();
                    string strSQL_GetQuesAns = $"select * from QUESTION QE join ANSWER A on A.QuesID = QE.QuesID where QE.QuesID in (select QuesID from QUIZ_QUESTION where QuizID = '{QuizID}')";

                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Program.connectionString))
                    {
                        var questionDictionary = new Dictionary<string , QuesAns>();

                        var list = connection.Query<QuesAns , Ans , QuesAns>(
                            strSQL_GetQuesAns ,
                            (question , answer) =>
                            {
                                QuesAns questionEntry;
                                if (!questionDictionary.TryGetValue(question.QuesID , out questionEntry))
                                {
                                    questionEntry = question;
                                    questionEntry.Answers = new List<Ans>();
                                    questionDictionary.Add(questionEntry.QuesID , question);
                                }
                                questionEntry.Answers.Add(answer);
                                return questionEntry;
                            } ,
                            splitOn: "AnsID"
                        ).Distinct().ToList();
                        liQuesAns = list;
                    }// --- end of var list = connection.Query ---

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ns , liQuesAns);
                    ns.Flush();
                    break;
                }// end if
            } //end While
        }

        // Kiểm tra câu trả lời và trả về kết quả 
        private void CheckAns (List<ClientAns> liClientAns , StreamWriter sw, string strQuizID , string strStuID)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;
                SqlDataReader sdr;
                List<string> liAns = new List<string>();

                // Lọc AnsID có IsTrue=1
                cmd = new SqlCommand(@"select AnsID from ANSWER ans where QuesID in (select qe.QuesID from Question qe, QUIZ_QUESTION qze where qe.QuesID = qze.QuesID and qze.QuizID = @QuizID) and IsTrue = 1" , sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                sdr = cmd.ExecuteReader();

                // Thêm dữ liệu vào mảng
                while (sdr.Read())
                    liAns.Add(sdr.GetString(0));
                sdr.Close();

                // Lấy số lượng câu hỏi của Quiz
                cmd = new SqlCommand(@"select QuesNum from QUIZ where QuizID = @QuizID" , sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                int   intQuesNum    = int.Parse(sdr.GetValue(0).ToString());
                float fltGrade      = 0;
                int   intCorrectAns = 0;

                // Dò AnsID ở liClientAns trong liAns
                for (int i = 0; i < 5; i++)
                {
                    if (liAns.Contains(liClientAns[i].AnsID) == true)
                        intCorrectAns++;
                }

                // Gửi kết quả
                fltGrade = (10 / intQuesNum) * intCorrectAns;
                sw.WriteLine("FINISH GRADED");
                sw.WriteLine(intCorrectAns);
                sw.WriteLine(fltGrade);

                // Lưu kết quả
                sdr.Close();
                cmd = new SqlCommand(@"update RESULT set Grade=@Grade where QuizID=@QuizID and StuID=@StuID" , sqlConnection);
                cmd.Parameters.AddWithValue("@Grade"  , fltGrade);
                cmd.Parameters.AddWithValue("@QuizID" , strQuizID);
                cmd.Parameters.AddWithValue("@StuID"  , strStuID);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                sqlConnection.Dispose();
                sqlConnection.Close();
            }
        }

        private void btn_quizresult_Click (object sender , EventArgs e)
        {
            (new server_result()).Show();

        }
    }
}
