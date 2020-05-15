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

        List<QuesAns> liQuesAns = new List<QuesAns>();

        // Server lắng nghe
        private void ServerListen()
        {
            TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                (new Thread(ServerProcess)).Start(tcpClient);
            }
        }

        // Kiểm tra login, lưu thông tin result, gửi đề, nhận đáp án, trả kết quả
        private void ServerProcess(object obj)
        {
            TcpClient tcpClient = (TcpClient)obj;
            StreamReader sr = new StreamReader(tcpClient.GetStream());
            StreamWriter sw = new StreamWriter(tcpClient.GetStream());

            if (LoginCheck(sr, sw) == false)
            {
                tcpClient.Close();
                MessageBox.Show("Ngắt kết nối");
                return;
            }

            MessageBox.Show(sr.ReadLine());
        }

        // Kiểm tra Login
        private bool LoginCheck(StreamReader sr, StreamWriter sw)
        {
            string strSignal = "";
            string strStuID = "";
            string strQuizID = "";

            //Vòng lặp kiểm tra login
            while (true)
            {
                strSignal = sr.ReadLine();
                if      (strSignal != "LOGIN")      continue;
                else if (strSignal == "DISCONNECT") return false;

                strStuID = sr.ReadLine();
                strQuizID = sr.ReadLine();

                if (strStuID == "18520093")
                    sw.WriteLine("LOGIN SUCCESS");

                else
                {
                    sw.WriteLine("LOGIN FAIL");
                    sw.Flush();
                    continue;
                }

                //Nhập dữ liệu vào table Result
                sw.Flush();
                MessageBox.Show("Login hoàn tất");
                break;
            }

            MessageBox.Show("Lưu thông tin hoàn tất");
            return true;
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
            (new server_resultlist()).Show();

        }
    }
}
