using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz
{
    [Serializable]
    public class Quiz
    {
        public string QuizID { get; set; }
        public string Title { get; set; }
        public int QuizTime { get; set; }
        public int QuesNum { get; set; }
    }
}
