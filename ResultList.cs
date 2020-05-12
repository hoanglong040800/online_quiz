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
    public partial class server_resultlist : Form
    {
        public server_resultlist()
        {
            InitializeComponent();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Program.sqlConnection.Open();

            //lấy toàn bộ dữ liệu;
            string strGetResult = "select * from QUIZ";
            SqlCommand cmdGetResult = new SqlCommand(strGetResult, Program.sqlConnection);
            cmdGetResult.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            (new SqlDataAdapter(cmdGetResult)).Fill(dt);
            dgv_result.DataSource = dt;

            //lấy từng dòng dữ liệu
            SqlDataReader dr = cmdGetResult.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr.GetString(0) + "\t" + dr.GetString(1) + "\t" + dr.GetByte(2) + "\t" + dr.GetByte(3));
            }
            Program.sqlConnection.Close();  
        }
    }
}
