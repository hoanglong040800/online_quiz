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
    public partial class client_quizinfo : Form
    {
        public client_quizinfo()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            (new client_quiz()).Show();
            Close();
        }
    }
}
