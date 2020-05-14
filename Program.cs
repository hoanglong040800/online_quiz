using System;
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
        public static string connectionString = @"Data Source=LongTran; Initial Catalog=online_quiz; Integrated Security=True";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new form_questiontest());
            
        }       
    }
}
