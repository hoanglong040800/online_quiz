using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class client_quiz : Form
    {
        public client_quiz()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            (new client_result()).Show();
            Close();
        }

        private int quick = 432000; // so phut * 60 * 60 ra dc quick vd : so phut = 20 * 60 * 60

        private void client_quiz_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3;
            timer.Tick += new EventHandler(timer_Tick);

            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            quick--;
            lb_countdown.Text = quick / 3600 + " : " + ( (quick % 3600)/60 >= 10 ? ((quick % 3600) / 60).ToString() : "0" + ((quick % 3600) / 60).ToString() );
            
            if (quick / 3600 == 0 && (quick % 3600) / 60 == 0)
                timer.Stop();
        }
    }
}
