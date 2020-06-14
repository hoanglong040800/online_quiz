using System.Windows.Forms;

namespace OnlineQuiz
{
    public partial class client_result : Form
    {
        public client_result(int intCorrectAns, float fltGrade)
        {
            InitializeComponent();
            lb_title.Text = client_login.quiz.Title;
            lb_mins.Text  = client_login.quiz.QuizTime.ToString();
            lb_CorrectAnswer.Text = intCorrectAns.ToString() + "/" + client_login.quiz.QuesNum;
            lb_Score.Text = fltGrade.ToString() + "/10";
        }

        private void btn_exit_Click (object sender , System.EventArgs e)
        {
            Close();
        }
    }
}
