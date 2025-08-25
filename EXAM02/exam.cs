using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public abstract class Exam
    {
        public int time { get; set; }
        public int numofquestion { get; set; }
        public List<Question> Question { get; set; }

        protected Exam(int time, int numofquestion)
        {
            time = time;
            numofquestion = numofquestion;
            Question = new List<Question>();
        }
        public abstract void Showexam();
    }
}
