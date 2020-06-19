using System;
using System.Windows.Forms;


namespace OnlineQuiz
{
    static class Program
    {
        public static string connectionString = @"Data Source=ADMIN-PC\SQLEXPRESS; Initial Catalog=online_quiz; Integrated Security=True; MultipleActiveResultSets=true;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new launcher());           
        }       
    }
}
