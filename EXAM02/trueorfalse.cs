using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Trueorfalse : Questions
    {
        public Trueorfalse(string header, string body, int marks)
            : base(header, body, marks)
        {
           Answerlist.Add(new Answer(1, "True"));
            Answerlist.Add(new Answer(2, "False"));
        }

        public object Answers { get; internal set; }

        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var ans in Answerlist)
            {
                Console.WriteLine(ans);
            }
        }
    }
}

