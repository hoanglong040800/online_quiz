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
        int intTimeSecond;
        int intTime;

        public client_quiz()
        {
            InitializeComponent();
            intTime = 120;
            intTimeSecond = intTime * 3600;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            (new client_result()).Show();
            Close();
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
                    timer.Stop();
                else intTimeSecond = 216000;
            }
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

                if (intTime < 60) timer.Stop();
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
        }
    }
}
