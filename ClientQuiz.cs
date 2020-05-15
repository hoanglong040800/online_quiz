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

namespace OnlineQuiz
{
    public partial class client_quiz : Form
    {
        public client_quiz()
        {
            InitializeComponent();
            returnclass rc = new returnclass();
            //  quizTimeFromServer = Int32.Parse(rc.scalarReturn(" select QuizTime from QUIZ where QuizID = '"+ client_login.quizID +" ' "));
            //    quizTimeFromServer = Int32.Parse ( rc.scalarReturn("select QuizTime from QUIZ where QuizID = '"+ client_login.quizID +" ' ") );
            quizTimeFromServer = 120;

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            (new client_quizresult()).Show();
            Close();
        }
        

        private int quick; // so phut * 60 * 60 ra dc quick vd : so phut = 20 * 60 * 60s
        private int quizTimeFromServer;
        private void ThoiGian_Chan(int n)
        {
            int hour = n / 60;
            if (hour <= 1)
                lb_countdown.Text = "00 :" + quick / 3600 + " : " + ((quick % 3600) / 60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString());
            else
            {
                if (quick * hour / 216000 < 1)

                    lb_countdown.Text = "00 : " + quick / 3600 + " : " + ((quick % 3600) / 60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString());
                else
                {


                    lb_countdown.Text = quick * hour / 216000 + " : " + quick / 3600 + " : " + ((quick % 3600) / 60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString());
                    // else a--;

                }
            }
            if (quick == 59 )
            {
                hour--;
                if (hour <= 0) timer.Stop();
                else
                {
                    quick = 216000;
                }

            }
        }

        // chon quick cho quizTimefromServer
        private void client_quiz_Load(object sender, EventArgs e)
        {
            textBox1.Text = quizTimeFromServer.ToString();
            timer = new Timer();
            timer.Interval = 3;
            timer.Tick += new EventHandler(timer_Tick);
                
            timer.Enabled = true;
           if (quizTimeFromServer <= 60 ) // dưới 1 tiếng 
           {
                if (quizTimeFromServer == 15) quick = 54000;
                else if (quizTimeFromServer == 30) quick = 108000;
                else if (quizTimeFromServer == 45) quick = 162000;
                else if (quizTimeFromServer == 60) quick = 216000;
                else if (quizTimeFromServer == 10) quick = 36000;
                else if (quizTimeFromServer == 20) quick = 72000;
               // xu_ly(quizTimeFromServer);
            } 
           else // giả sử đè thi 90 phút , 120 phút thi se xet , dep hay xau  
           {
                if (quizTimeFromServer % 60 == 0) quick = 216000;
               
                else
                {
                    // 1 tieng 15 phut 
                    if  ( (quizTimeFromServer % 60) < 30 ) // 1 tieng 15 phut hoac 2 tieng 15 phut 
                    
                        quick = 54000;
                     //   phut_15(quizTimeFromServer);

                    
                    else if ( (quizTimeFromServer % 60) > 30 ) // 1 tieng 45 phut hoac 2 tieng 45 phut 
                    
                        quick = 162000;
                      //  phut_45(quizTimeFromServer);
                    
                    else
                    
                        quick = 108000;
                      //  phut_30(quizTimeFromServer);
                    
                }
           }
        }
        private void ThoiGian_Le(int n)
        {
            int hour = n / 60;
            if (n <= 60)
            {

                lb_countdown.Text = "00 :" + quick / 3600 + " : " + ((quick % 3600) / 60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString());
                //  textBox1.Text = "123";
            }
            else
            {
                //  textBox1.Text = "456";
                lb_countdown.Text = hour + " : " + quick / 3600 + " : " + ((quick % 3600) / 60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString());
            }
           // textBox2.Text = quick.ToString();
            if (quick == 59)
            {
                if ((quizTimeFromServer % 60) < 30) quizTimeFromServer -= 15;
                else if ((quizTimeFromServer % 60) > 30) quizTimeFromServer -= 45;
                else quizTimeFromServer -= 30;
                if (quizTimeFromServer < 60) timer.Stop();
                else quick = 216000;

            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            quick--;
            if (quizTimeFromServer % 60 == 0 || quizTimeFromServer < 60)
            {
               ThoiGian_Chan(quizTimeFromServer);
            }
            else
                ThoiGian_Le(quizTimeFromServer);
        }

        private void lb_countdown_Click(object sender, EventArgs e)
        {

        }
    }
}
