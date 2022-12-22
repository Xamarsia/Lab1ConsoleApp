using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class Student : IID
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int GroupID { get; set; }

        public Student(string name, string surname, int age, int groupID)
        {
            Name = name;
            Surname = surname;
            Age = age;
            GroupID = groupID;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + Name + " " + Surname + " " + Age + " " + GroupID);
        }
    }
}
