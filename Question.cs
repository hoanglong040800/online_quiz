using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz
{
    class Question
    {
        public string QuesID { get; set; }
        public string QuesContent { get; set; }
        public string PictureLink { get; set; }
        public List<Answer> Answers { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ QuesID } { QuesContent } ({PictureLink}) {Answers}";
            }
        }

    }
}
