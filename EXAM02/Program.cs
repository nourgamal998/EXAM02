
using EXAM02;

var subject = new Subject(1, "Programming Fundamentals");


Console.Write("Choose exam type (final/practical): ");
string type = (Console.ReadLine() ?? "").Trim().ToLower();


Console.Write("Enter exam duration (minutes): ");
int duration = int.Parse(Console.ReadLine() ?? "60");


Console.Write("Enter number of questions: ");
int numQuestions = int.Parse(Console.ReadLine() ?? "1");

Exam exam;
if (type.StartsWith("p"))
    exam = new Practecal(duration, numQuestions);
else
    exam = new Finalexam(duration, numQuestions);


for (int i = 0; i < numQuestions; i++)
{
    Console.WriteLine($"\n--- Question {i + 1} ---");
    Console.Write("Enter question header: ");
    string header = Console.ReadLine() ?? "";
    Console.Write("Enter question body: ");
    string body = Console.ReadLine() ?? "";
    Console.Write("Enter question mark: ");
    int mark = int.Parse(Console.ReadLine() ?? "1");

    Questions question;

    if (type.StartsWith("f"))
    {
        Console.Write("Enter question type (mcq/truefalse): ");
        string qType = (Console.ReadLine() ?? "").Trim().ToLower();

        if (qType.StartsWith("true"))
        {
            var tfq = new Trueorfalse(header, body, mark);
            Console.Write("Enter correct answer (True/False): ");
            string answer = (Console.ReadLine() ?? "").Trim();
            // tfq.rightanswer = tfq.Answers.Find(a => a.text.Equals(answer, StringComparison.OrdinalIgnoreCase));
            question = tfq;
        }
        else
        {
            var mcq = new Mcq(header, body, mark);
            Console.Write("Enter number of choices: ");
            int numChoices = int.Parse(Console.ReadLine() ?? "2");
            for (int j = 0; j < numChoices; j++)
            {
                Console.Write($"Enter choice {j + 1}: ");
                string choice = Console.ReadLine() ?? "";
                mcq.Answerlist.Add(new Answer(j + 1, choice));
            }
            Console.Write("Enter correct answer text: ");
            string correct = Console.ReadLine() ?? "";
            mcq.rightanswer = mcq.Answer.Find(a => a.AnswerText.Equals(correct, StringComparison.OrdinalIgnoreCase));
            question = mcq;
        }
    }
    else
    {
        var mcq = new Mcq(header, body, mark);
        Console.Write("Enter number of choices: ");
        int numChoices = int.Parse(Console.ReadLine() ?? "2");
        for (int j = 0; j < numChoices; j++)
        {
            Console.Write($"Enter choice {j + 1}: ");
            string choice = Console.ReadLine() ?? "";
            mcq.Answerlist.Add(new Answer(j + 1, choice));
        }
        Console.Write("Enter correct answer text: ");
        string correct = Console.ReadLine() ?? "";
        //mcq.rightanswer = mcq.Answers.Find(a => a.AnswerText.Equals(correct, StringComparison.OrdinalIgnoreCase));
        question = mcq;
    }

    exam.Question.Add(question);
}

exam.numofquestion = exam.Question.Count;
subject.createxam(exam);
Console.WriteLine("\n--- Exam Created ---");
Console.WriteLine(subject);
subject.Exam.Showexam();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
