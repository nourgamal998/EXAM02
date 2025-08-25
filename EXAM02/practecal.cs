using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXAM02;

namespace EXAM02
{
    public class Practecal : Exam
    {
        public Practecal(int time, int numofquestion)
            : base(time, numofquestion) { }

        public override void Showexam()
        {
            foreach (var q in Question)
            {
                q.Display();
                Console.WriteLine("enter answer id ");
                Console.ReadLine();
               // Console.WriteLine($"correct answers {q.rightanswer.AnswerId} - {q.rightanswer.AnswerList}\n");
            }
        }
    }
}
