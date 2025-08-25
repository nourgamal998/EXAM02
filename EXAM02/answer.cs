using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Answer
    {
        public int answerid { get; set; }
        public string answertext { get; set; }

        public Answer(int answerid, string text)
        {
            answerid = answerid;
            answertext = text;
        }
        public override string ToString()
        { 
            return $"Answer ID: {answerid}, Answer Text: {answertext}";
        }
    }

}
