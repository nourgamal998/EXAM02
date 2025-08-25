using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Trueorfalse : Question
    {
        public Trueorfalse(string header, string body, int marks)
            : base(header, body, marks)
        {
           answerlist.Add(new Answer(1, "True"));
            answerlist.Add(new Answer(2, "False"));
        }
        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var ans in answerlist)
            {
                Console.WriteLine(ans);
            }
        }
    }
}

