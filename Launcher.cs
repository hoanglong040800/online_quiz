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
    public partial class launcher : Form
    {
        public launcher()
        {
            InitializeComponent();
            (new server_launcher()).Show();
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            (new client_login()).Show();
        }
    }
}
