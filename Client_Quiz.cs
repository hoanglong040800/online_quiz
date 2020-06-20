using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OnlineQuiz
{

    public partial class client_quiz:Form
    {

        int intTimeSecond;
        int intTime;
        bool boolCheckTimeOut = false;
        int intCurPage = 1;
        List<ClientAns> liClientAns = new List<ClientAns>(client_login.quiz.QuesNum);

        public client_quiz ()
        {
            InitializeComponent();
            intTime = client_login.quiz.QuizTime ;
            intTimeSecond = intTime * 3600;
            label2.Text = "/" + client_login.quiz.QuesNum;

            // quá trình khỏi tạo liClientAns , gán mọi phần tử = "" hết vì thằng nhóm trưởng yêu cầu  
            ClientAns ca = new ClientAns();
            ca.AnsID = "";
            ca.QuesID = "";
            for(int i = 0; i< client_login.quiz.QuesNum; i++)
            {
                liClientAns.Add(ca);
            }    

        }

        // ---------------- Timer --------------

        private void client_quiz_Load (object sender , EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;

            // dưới 1 tiếng 
            if (intTime <= 60)
            {
                if (intTime == 15)
                    intTimeSecond = 54000;
                else if (intTime == 30)
                    intTimeSecond = 108000;
                else if (intTime == 45)
                    intTimeSecond = 162000;
                else if (intTime == 60)
                    intTimeSecond = 216000;
                else if (intTime == 10)
                    intTimeSecond = 36000;
                else if (intTime == 20)
                    intTimeSecond = 72000;

            }

            // giả sử đè thi 90 phút , 120 phút thi se xet , dep hay xau
            else
            {
                if (intTime % 60 == 0)
                    intTimeSecond = 216000;

                else
                {
                    if (( intTime % 60 ) < 30) // 1 tieng 15 phut hoac 2 tieng 15 phut                    
                        intTimeSecond = 54000;

                    else if (( intTime % 60 ) > 30) // 1 tieng 45 phut hoac 2 tieng 45 phut                 
                        intTimeSecond = 162000;

                    else
                        intTimeSecond = 108000;
                }
            }
            if (intCurPage == 1) btnPrevious.Visible = false;
            
            // Tải đề
            LoadQuesAns();
        }

        private void timer_Tick (object sender , EventArgs e)
        {
            intTimeSecond--;
            if (intTime % 60 == 0 || intTime < 60)
                ThoiGian_Chan(intTime);

            else
                ThoiGian_Le(intTime);

            if (boolCheckTimeOut)
            {
                MessageBox.Show("Đã hết thời gian làm bài!");
                SendClientAns();
            }
        }

        private void ThoiGian_Chan (int n)
        {
            int hour = n / 60;
            if (hour <= 1)
                lb_countdown.Text = "00 :" + intTimeSecond / 3600 + " : " + ( ( intTimeSecond % 3600 ) / 60 >= 10 ? ( ( intTimeSecond % 3600 ) / 60 ).ToString() : "0" + ( ( intTimeSecond % 3600 ) / 60 ).ToString() );
            else
            {
                if (intTimeSecond * hour / 216000 < 1)
                    lb_countdown.Text = "00 : " + intTimeSecond / 3600 + " : " + ( ( intTimeSecond % 3600 ) / 60 >= 10 ? ( ( intTimeSecond % 3600 ) / 60 ).ToString() : "0" + ( ( intTimeSecond % 3600 ) / 60 ).ToString() );
                else
                    lb_countdown.Text = intTimeSecond * hour / 216000 + " : " + intTimeSecond / 3600 + " : " + ( ( intTimeSecond % 3600 ) / 60 >= 10 ? ( ( intTimeSecond % 3600 ) / 60 ).ToString() : "0" + ( ( intTimeSecond % 3600 ) / 60 ).ToString() );
            }
            if (intTimeSecond == 59)
            {
                hour--;
                if (hour <= 0)
                {
                    timer.Stop();
                    boolCheckTimeOut = true;
                }
                else
                    intTimeSecond = 216000;
            }
        }

        private void ThoiGian_Le (int n)
        {
            int hour = n / 60;
            if (n <= 60)
                lb_countdown.Text = "00 :" + intTimeSecond / 3600 + " : " + ( ( intTimeSecond % 3600 ) / 60 >= 10 ? ( ( intTimeSecond % 3600 ) / 60 ).ToString() : "0" + ( ( intTimeSecond % 3600 ) / 60 ).ToString() );

            else
                lb_countdown.Text = hour + " : " + intTimeSecond / 3600 + " : " + ( ( intTimeSecond % 3600 ) / 60 >= 10 ? ( ( intTimeSecond % 3600 ) / 60 ).ToString() : "0" + ( ( intTimeSecond % 3600 ) / 60 ).ToString() );

            if (intTimeSecond == 59)
            {
                if (( intTime % 60 ) < 30)
                    intTime -= 15;
                else if (( intTime % 60 ) > 30)
                    intTime -= 45;
                else
                    intTime -= 30;

                if (intTime < 60)
                {
                    timer.Stop();
                    boolCheckTimeOut = true;
                }
                else
                    intTimeSecond = 216000;
            }
        }

        // -------------- Thay đổi số trang ------------------

        private void textBoxTest_KeyDown (object sender , KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this , new EventArgs());
            }
        }

        private void btnSearch_Click (object sender , EventArgs e)
        {
            CheckBoxOff();
            intCurPage = int.Parse(tb_curPage.Text);
            LoadQuesAns();

            if (intCurPage <= liClientAns.Count)
                ShowCheckedAns();
        }

        private void btnPrevious_Click (object sender , EventArgs e)
        {



            btnNext.Visible = true;
           
                // số câu phải hợp lệ thì mới lưu kết quả 
                if (intCurPage <= client_login.quiz.QuesNum && intCurPage >= 1 )
                    SavedAns();
                intCurPage--;
            if (intCurPage == 1) btnPrevious.Visible = false;

                // những câu đã làm thì load câu đó và load câu trả lời đã làm 
                // ở đây ko đi tới rẽ nhánh  IF thứ 3 đâu 
             if (intCurPage <= liClientAns.Count)
                {
                    LoadQuesAns();
                    ShowCheckedAns();
                }

           
            
        }

        private void btnNext_Click (object sender , EventArgs e)
        {
            btnPrevious.Visible = true;


            // kiểm tra câu sau khi bấm next đó đã làm hay chưa

            //  btnNext.Visible = true;
           
            // số câu phải hợp lệ thì mới lưu kết quả 
            if (intCurPage <= client_login.quiz.QuesNum && intCurPage >= 1)
                    SavedAns();
                intCurPage++;
            if (intCurPage == client_login.quiz.QuesNum ) btnNext.Visible = false;

            // những câu đã làm thì load câu đó và load câu trả lời đã làm 
            if (intCurPage <= liClientAns.Count)
                {
                    LoadQuesAns();
                    ShowCheckedAns();
                }

                // những câu chưa làm thì chắc chắn sẽ checkboxOff và load câu mới 
                else
                {
                    CheckBoxOff();
                    LoadQuesAns();
                }
            }
        
                      

        

        private void CheckBoxOff ()
        {
            rb_ans1.Checked = false;
            rb_ans2.Checked = false;
            rb_ans3.Checked = false;
            rb_ans4.Checked = false;
        }

        // Tải câu hỏi và đáp án khi đổi trang
        private void LoadQuesAns ()
        {
            
                lb_ques.Text = client_login.liQuesAns[intCurPage - 1].QuesContent;
                rb_ans1.Text = client_login.liQuesAns[intCurPage - 1].Answers[0].AnsContent;
                rb_ans2.Text = client_login.liQuesAns[intCurPage - 1].Answers[1].AnsContent;
                rb_ans3.Text = client_login.liQuesAns[intCurPage - 1].Answers[2].AnsContent;
                rb_ans4.Text = client_login.liQuesAns[intCurPage - 1].Answers[3].AnsContent;
                tb_curPage.Text = intCurPage.ToString();

                if (client_login.liQuesAns[intCurPage - 1].PictureLink != "")
                {
                    string path = @"../QuesPicture/" + client_login.liQuesAns[intCurPage - 1].PictureLink.ToString();
                    pb_ques.Load(path);
                    pb_ques.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                pb_ques.InitialImage = null;
                pb_ques.Image = null;
                }
            
            
        }

        private void CheckAnsID ()
        {
            string path = @"E:\ansID.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                int i = 0;
                while (i < liClientAns.Count)
                {
                    sw.WriteLine(liClientAns[i].QuesID + "   " + liClientAns[i].AnsID);
                    i++;
                }
            }
        }

        private void ShowCheckedAns ()
        {
            if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[0].AnsID)
                rb_ans1.Checked = true;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[1].AnsID)
                rb_ans2.Checked = true;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[2].AnsID)
                rb_ans3.Checked = true;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[3].AnsID)
                rb_ans4.Checked = true;
            else
                CheckBoxOff();
        }

        // ------------------- Nộp và gửi kết quả cho server -------------------

        private void btn_submit_Click (object sender , EventArgs e)
        {
            if (intCurPage <= client_login.quiz.QuesNum && intCurPage >= 1)
                SavedAns();
            SendClientAns();
        }

        private void SavedAns()
        {
            string quesID = client_login.liQuesAns[intCurPage - 1].QuesID;
            string ansID;
            if (rb_ans1.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[0].AnsID;

            else if (rb_ans2.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[1].AnsID;

            else if (rb_ans3.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[2].AnsID;

            else if (rb_ans4.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[3].AnsID;

            else
                ansID = "null";

            ClientAns ca = new ClientAns
            {
                QuesID = quesID ,
                AnsID = ansID
            };
            
            // ghi đè giá trị lên các phần tử rỗng ban đầu của liClientAns
            for (int i = 0; i < liClientAns.Count; i++)
            {
                /*
                if (ca.QuesID == liClientAns[i].QuesID)
                {
                    liClientAns[i] = ca;
                    CheckAnsID();
                    return;
                }
                else */
                if ( intCurPage-1 == i ) {
                    liClientAns[i] = ca;
                    CheckAnsID();
                    break;
                    }

            }
                
            
         //   liClientAns.Add(ca);

          //  CheckAnsID();
        }

        // Gửi câu trả lời cho Server
        private void SendClientAns ()
        {
            // gui list <ClientAns> cho server
            Client cli      = new Client();
            StreamReader sr = new StreamReader(cli.ns);
            StreamWriter sw = new StreamWriter(cli.ns);

            //gui thong bao va QuizID, StuUD
            sw.WriteLine($"SUBMIT: {client_login.strQuizIDGlobal} {client_login.strStuIDGlobal}");
            sw.Flush();

            string strRespone = "";
            while (true)
            {
                strRespone = sr.ReadLine();
                if (strRespone == "CLIENTANS")
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(cli.ns , liClientAns);
                    cli.ns.Flush();
                    break;
                }
            }
            // Xóa hết dữ liệu bên client
            clearAllDataFromClient();

            // Nhận kết quả
            if (sr.ReadLine() == "FINISH GRADED")
            {
                (new client_result( int.Parse(sr.ReadLine()) , float.Parse(sr.ReadLine()) )).Show();
                cli.CloseConnection();
                timer.Stop();
                Close();
            }
        }

        private void clearAllDataFromClient()
        {
            // xóa list gì thì gọi hàm Clear() của list đó .
            client_login.liQuesAns.Clear();
            liClientAns.Clear();
        }
    }
}
