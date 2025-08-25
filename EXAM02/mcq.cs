using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Mcq : Question
    {
        public Mcq(string header, string body, int marks)
            : base(header, body, marks) { }

        public override void Display()
        {
            Console.WriteLine(this);
            foreach (var answer in answerlist)
            {
                Console.WriteLine(answer);
            }
        }
    }
}

