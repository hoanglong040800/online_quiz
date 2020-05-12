using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineQuiz
{
    public partial class server_launcher : Form
    {
        public server_launcher()
        {
            InitializeComponent();

        }


        private void btn_quizresult_Click(object sender, EventArgs e)
        {
            (new server_resultlist()).Show();
        }
    }
}
