using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;

namespace OnlineQuiz
{

    public partial class client_quiz : Form
    {
       
        int intTimeSecond;
        int intTime;
        bool boolCheckTimeOut = false;
        int intCurPage = 1;
        List<ClientAns> liClientAns = new List<ClientAns>();
        private object resources;

        //ClientAns[] liClientAns = new ClientAns[3];


        public client_quiz()
        {
            InitializeComponent();
            intTime = 3;
            intTimeSecond = intTime * 3600;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            savedAns();
            sendClientAns();
            
        }
               
        private void ThoiGian_Chan(int n)
        {
            int hour = n / 60;
            if (hour <= 1)
                lb_countdown.Text = "00 :" + intTimeSecond / 3600 + " : " + ((intTimeSecond % 3600) / 60 >= 10 ? ((intTimeSecond % 3600) / 60).ToString() : "0" + ((intTimeSecond % 3600) / 60).ToString());
            else
            {
                if (intTimeSecond * hour / 216000 < 1)
                    lb_countdown.Text = "00 : " + intTimeSecond / 3600 + " : " + ((intTimeSecond % 3600) / 60 >= 10 ? ((intTimeSecond % 3600) / 60).ToString() : "0" + ((intTimeSecond % 3600) / 60).ToString());
                else
                    lb_countdown.Text = intTimeSecond * hour / 216000 + " : " + intTimeSecond / 3600 + " : " + ((intTimeSecond % 3600) / 60 >= 10 ? ((intTimeSecond % 3600) / 60).ToString() : "0" + ((intTimeSecond % 3600) / 60).ToString());
            }
            if (intTimeSecond == 59 )
            {
                hour--;
                if (hour <= 0)
                {
                    timer.Stop();
                    boolCheckTimeOut = true;
                }
                else intTimeSecond = 216000;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            intTimeSecond--;
            if (intTime % 60 == 0 || intTime < 60)
                ThoiGian_Chan(intTime);
            else
                ThoiGian_Le(intTime);
            if (boolCheckTimeOut) sendClientAns();
        }

        // chon quick cho intTime
        private void client_quiz_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;

            // dưới 1 tiếng 
            if (intTime <= 60 ) 
            { 
                if (intTime == 15) intTimeSecond = 54000;
                else if (intTime == 30) intTimeSecond = 108000;
                else if (intTime == 45) intTimeSecond = 162000;
                else if (intTime == 60) intTimeSecond = 216000;
                else if (intTime == 10) intTimeSecond = 36000;
                else if (intTime == 20) intTimeSecond = 72000;
               
            } 

           else // giả sử đè thi 90 phút , 120 phút thi se xet , dep hay xau  
           {
                if (intTime % 60 == 0) intTimeSecond = 216000;
               
                else
                {
                    if  ( (intTime % 60) < 30 ) // 1 tieng 15 phut hoac 2 tieng 15 phut                    
                        intTimeSecond = 54000;
               
                    else if ( (intTime % 60) > 30 ) // 1 tieng 45 phut hoac 2 tieng 45 phut                 
                        intTimeSecond = 162000;
                    
                    else                   
                        intTimeSecond = 108000;             
                }
           }


            loadQuesAns();
         

        }
        private void ThoiGian_Le(int n)
        {
            int hour = n / 60;
            if (n <= 60)
                lb_countdown.Text = "00 :" + intTimeSecond / 3600 + " : " + ((intTimeSecond % 3600) / 60 >= 10 ? ((intTimeSecond % 3600) / 60).ToString() : "0" + ((intTimeSecond % 3600) / 60).ToString());

            else
                lb_countdown.Text = hour + " : " + intTimeSecond / 3600 + " : " + ((intTimeSecond % 3600) / 60 >= 10 ? ((intTimeSecond % 3600) / 60).ToString() : "0" + ((intTimeSecond % 3600) / 60).ToString());

            if (intTimeSecond == 59)
            {
                if ((intTime % 60) < 30) intTime -= 15;
                else if ((intTime % 60) > 30) intTime -= 45;
                else intTime -= 30;

                if (intTime < 60)
                {
                    timer.Stop();
                    boolCheckTimeOut = true;
                }
                else intTimeSecond = 216000;
            }
        }

        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
        private void loadQuesAns()
        {
            lb_ques.Text = client_login.liQuesAns[intCurPage - 1].QuesContent;
            cb_ans1.Text = client_login.liQuesAns[intCurPage - 1].Answers[0].AnsContent;
            cb_ans2.Text = client_login.liQuesAns[intCurPage - 1].Answers[1].AnsContent;
            cb_ans3.Text = client_login.liQuesAns[intCurPage - 1].Answers[2].AnsContent;
            cb_ans4.Text = client_login.liQuesAns[intCurPage - 1].Answers[3].AnsContent;
            tb_curPage.Text = intCurPage.ToString();
            if (client_login.liQuesAns[intCurPage - 1].PictureLink != "")
            {
                //string path = @"D:\QE0" + intCurPage.ToString() + ".png" ; 
                string path = @"../QuesPicture/" + client_login.liQuesAns[intCurPage - 1].PictureLink.ToString();


                pb_ques.Load(path);
                pb_ques.SizeMode = PictureBoxSizeMode.StretchImage;


            }
            //else
            //{ 
            //    string path = @"D:\Long.png";
            //    pb_ques.Load(path);
            //    pb_ques.SizeMode = PictureBoxSizeMode.StretchImage;
            //}

        }
        private void checkBoxOff()
        {
            cb_ans1.Checked = false;
            cb_ans2.Checked = false;
            cb_ans3.Checked = false;
            cb_ans4.Checked = false;
        }
        private void savedAns()
        {
            string quesID =   client_login.liQuesAns[intCurPage - 1].QuesID;
            string ansID; 
            if (cb_ans1.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[0].AnsID;
            else if (cb_ans2.Checked)
                 ansID = client_login.liQuesAns[intCurPage - 1].Answers[1].AnsID;
            else if (cb_ans3.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[2].AnsID;
            else if (cb_ans4.Checked)
                ansID = client_login.liQuesAns[intCurPage - 1].Answers[3].AnsID;
            else
                ansID = "null";
            ClientAns ca = new ClientAns();
            ca.QuesID = quesID;
            ca.AnsID = ansID;
            // xoa' nhung phan` tu bi trung` 

            for (int i = 0; i < liClientAns.Count; i++)
            {
                if (ca.QuesID == liClientAns[i].QuesID) liClientAns.RemoveAt(i);
            }
            liClientAns.Add(ca);
          
        }
        private void checkAnsID()
        {
            string path = @"E:\ansID.txt";
            using (StreamWriter sw = new StreamWriter(path) )
            {
                int i = 0;
                while (i < liClientAns.Count)
                {
                    sw.WriteLine(liClientAns[i].QuesID + "   " + liClientAns[i].AnsID);
                    i++;

                }
            }
        }


        
        private void sendClientAns() {
            // gui list <ClientAns> cho server
            TcpClient tcpClient = new TcpClient();
            IPEndPoint remoteHost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient.Connect(remoteHost);
            BinaryFormatter bf = new BinaryFormatter();
            NetworkStream ns = tcpClient.GetStream();
           // foreach (var item in liClientAns)
           // {
                bf.Serialize(ns, liClientAns);
         //   }
            ns.Flush();

            (new client_result()).Show();
            Close();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            savedAns();
            checkBoxOff();
            intCurPage++;
            if (intCurPage == 4) checkAnsID(); 
            // (new client_quiz()).Show();
            // Close();
            loadQuesAns();
            if (intCurPage <= liClientAns.Count )
            showPreAns();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            intCurPage--;
            checkBoxOff();
            loadQuesAns();
            showPreAns();

        }
        private void showPreAns()
        {
            
               if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[0].AnsID) cb_ans1.Checked = true ;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[1].AnsID) cb_ans2.Checked = true;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[2].AnsID) cb_ans3.Checked = true;
            else if (liClientAns[intCurPage - 1].AnsID == client_login.liQuesAns[intCurPage - 1].Answers[3].AnsID) cb_ans4.Checked = true;
          
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

                checkBoxOff();
                intCurPage = Int32.Parse(tb_curPage.Text);
                loadQuesAns();
            if (intCurPage <= liClientAns.Count)
                showPreAns();
                
            
        }
        //  private void tb_curPage_TextChanged(object sender, EventArgs e)

    }
}
