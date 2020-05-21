using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuiz
{
    [Serializable]
    class Ans
    {
        public string AnsID { get; set; }
        public string QuesID { get; set; }
        public string AnsContent { get; set; }
        public bool isTrue { get; set; }
    }
}
