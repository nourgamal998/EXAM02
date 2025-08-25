namespace EXAM02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var subject = new Subject(1, "programming");

            Console.WriteLine("choosse exam type : 1-final , 2-practical ");
            int type = int.Parse(Console.ReadLine());

            Exam exam;
            if (type == 1)
            {
                exam = new Finalexam(60,2);

                var q1 = new Trueorfalse("Is 2+2=4?", "Math question", 5);
                q1.rightanswer = q1.answerist[1];

                q1.rightanswer = new answerlist { 1, "True" };
                var q2 = new Mcq("Q2", "Which is not a .NET language?", 5);
                q2.answerlist.Add(new Answer(1, "C#"));
                q2.answerlist.Add(new Answer(2, "c++"));
                q2.answerlist.Add(new Answer(3, "Python"));
                q2.answerlist.Add(new Answer(4, "F#"));
                q2.answerlist = q2.answerlist[2];

                exam.Question.Add(q1);
                exam.Question.Add(q2);
            }
            else
            {
                exam = new Practecal(30, 1);

                var q1 = new Mcq("Q1", "Which of the following is a value type?", 5);
                q1.answerlist.Add(new Answer(1, "string"));
                q1.answerlist.Add(new Answer(2, "int"));
                q1.answerlist.Add(new Answer(3, "object"));
                q1.answerlist.Add(new Answer(4, "dynamic"));
                q1.rightanswer = q1.answerlist[1];

                exam.Question.Add(q1);
            }

            subject.createxam(exam);

            Console.WriteLine($"\n{subject}\n--- Starting Exam ---\n");
            subject.Exam.Showexam();
        }

    }
    }

