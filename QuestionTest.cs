using Dapper;
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
    public partial class QuestionTest : Form
    {
        public QuestionTest()
        {

            InitializeComponent();
        }
        List<Question> questions = new List<Question>();
        private void Update()
        {
            lbQuestion.DataSource = questions;
            lbQuestion.DisplayMember = "FullInfo";
        }


        private void btnShowQuestion_Click(object sender, EventArgs e)
        {
            string sql = "select *  from QUESTION QE join  ANSWER A on A.QuesID = QE.QuesID where exists (select * from QUIZ_QUESTION where QuizID = 'QZ01');"; //select cau hoi theo quizid
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionString.connectionString))
            {
                var questionDictionary = new Dictionary<string, Question>();
                var list = connection.Query<Question, Answer, Question>(
                    sql,
                    (question, answer) =>
                    {
                        Question questionEntry;
                        if (!questionDictionary.TryGetValue(question.QuesID, out questionEntry))
                        {
                            questionEntry = question;
                            questionEntry.Answers = new List<Answer>();
                            questionDictionary.Add(questionEntry.QuesID, question);
                        }

                        questionEntry.Answers.Add(answer);
                        return questionEntry;
                    }, splitOn: "AnsID")
                    .Distinct()
                    .ToList();
                questions = (List<Question>)list;
            }
            Update();
        }
    }
}
