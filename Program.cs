using System;
using System.Windows.Forms;


namespace OnlineQuiz
{
    static class Program
    {
        public static string connectionString = @"Data Source=LongTran; Initial Catalog=online_quiz; Integrated Security=True; MultipleActiveResultSets=true;";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new server_launcher());           
        }       
    }
}
