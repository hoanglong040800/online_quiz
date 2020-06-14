using System;
using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class client_quizinfo : Form
    {
        //Truyền dữ liệu tham chiếu từ client_login
        public client_quizinfo()
        {
            InitializeComponent();
            lb_title.Text = client_login.quiz.Title;
            lb_mins.Text  = client_login.quiz.QuizTime.ToString();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            (new client_quiz()).Show();
            Close();
        }
    }
}
