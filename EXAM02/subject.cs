using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM02
{
    public class Subject
    {
        public int subjectid { get; set; }
        public string subjectname { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            subjectid = id;
            subjectname = name;
        }
        public void createxam(Exam exam)
        {
            Exam = exam;
        }
        public override string ToString()
        {
            return $"Subject ID: {subjectid}, Subject Name: {subjectname}";
        }


    }
}
