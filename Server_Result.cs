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
    public partial class server_result : Form
    {
        public server_result()
        {
            InitializeComponent();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Program.connectionString))
            {
                sqlConnection.Open();
                SqlCommand cmd;

                cmd = new SqlCommand("select QuizID from QUIZ where QuizID = @QuizID",sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID", tb_quizID.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Không tồn tại mã Quiz " + tb_quizID.Text);
                    return;
                }

                cmd = new SqlCommand("select st.StuID, Fullname, Grade from RESULT re, STUDENT st where re.StuID = st.StuiD and QuizID=@QuizID", sqlConnection);
                cmd.Parameters.AddWithValue("@QuizID", tb_quizID.Text);

                DataTable dt = new DataTable();
                (new SqlDataAdapter(cmd)).Fill(dt);
                dgv_result.DataSource = dt;
                dgv_result.Columns[0].Width = 130;
                dgv_result.Columns[1].Width = 240;
                dgv_result.Columns[2].Width = 87;

                sqlConnection.Close();
            }
        }
    }
}
