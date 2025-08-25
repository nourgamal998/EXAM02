using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public abstract class Questions
    {
        public string header { get; set; }
        public string body { get; set; }
        public int marks { get; set; }
        public List<Answer> Answerlist { get; set; }
        public string rightanswer { get; set; }

        protected Questions(string header, string body, int marks)
        {
            header = header;
            body = body;
            marks = marks;
            Answerlist = new List<Answer>();
        }
        abstract public void Display();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int comparto(Questions other)
        {
            return this.marks.CompareTo(other.marks);
        }
        public override string ToString()
        {
            return $"[{header}] {body} ({marks})";
        }
    }
}
