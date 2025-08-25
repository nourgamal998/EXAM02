using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    //public class Answer
    //{
    //    public int answerid { get; set; }
    //    public string answertext { get; set; }

    //    public Answer(int id, string text)
    //    {
    //        answerid = id;
    //        answertext = text;
    //    }
    //    public override string ToString()
    //    { 
    //        return $"Answer ID: {answerid}, Answer Text: {answertext}";
    //    }
    //}
    public class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        public object Clone()=>new Answer(AnswerId,AnswerText);

        public override string ToString()
        {
            return $"Answer ID: {AnswerId}, Answer Text: {AnswerText}";
        }
    }
}
