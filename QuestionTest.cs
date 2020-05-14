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
    public partial class form_questiontest : Form
    {
        public form_questiontest()
        {

            InitializeComponent();
        }

        List<QuesAns> liQuesAns = new List<QuesAns>();

        private void Update()
        {
            lbQuestion.DataSource = liQuesAns;
            lbQuestion.DisplayMember = "FullInfo";
        }

        private void btnShowQuestion_Click(object sender, EventArgs e)
        {
            //select QUESTION by QuizID
            string strSQL_GetQuesAns = "select * from QUESTION QE join ANSWER AS on AS.QuesID = QE.QuesID where exists (select * from QUIZ_QUESTION where QuizID = 'QZ01')"; 

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Program.connectionString))
            {
                var questionDictionary = new Dictionary<string, QuesAns>();

                var list = connection.Query<QuesAns, Ans, QuesAns>(
                    strSQL_GetQuesAns,
                    (question, answer) =>
                    {
                        QuesAns questionEntry;
                        if (!questionDictionary.TryGetValue(question.QuesID, out questionEntry))
                        {
                            questionEntry = question;
                            questionEntry.Answers = new List<Ans>();
                            questionDictionary.Add(questionEntry.QuesID, question);
                        }
                        questionEntry.Answers.Add(answer);
                        return questionEntry;
                    }, 
                    splitOn: "AnsID"
                ).Distinct().ToList();
                // --- end of var list = connection.Query ---

                liQuesAns = list;
            }
            Update();
        }
    }
}
