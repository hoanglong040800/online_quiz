﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OnlineQuiz
{
    static class Program
    {
        public static SqlConnection sqlConnection = new SqlConnection(@"Data Source=LongTran; Initial Catalog=online_quiz; Integrated Security=True");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            sqlConnection.Open();
            Application.Run(new client_quiz());
            sqlConnection.Close();
        }       
    }
}