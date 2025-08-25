using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Finalexam : Exam
    {
        public Finalexam( int time , int numofquestion) 
               : base(time , numofquestion) { }

        public string AnswerId { get; private set; }

        public override void Showexam()
        {
            int grade = 0;
            foreach (var q in Question)
            {
                q.Display();
                Console.WriteLine("enter the answer");
               
                int ansid=int.Parse(Console.ReadLine());

                if (q.rightanswer != null && q.rightanswer == AnswerId)
                    
                {
                    grade += q.marks;
                }
                Console.WriteLine($"\nYour grade is: {grade} / {Question.Sum(q => q.marks)}");
            }
        }
    }
}
