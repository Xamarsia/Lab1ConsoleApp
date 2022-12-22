using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class Subject : IID
    {

        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int Hours { get; set; }

        public Subject(string subjectName, int hours)
        {
            SubjectName = subjectName;
            Hours = hours;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + SubjectName + " " + Hours);
        }
    }
}
