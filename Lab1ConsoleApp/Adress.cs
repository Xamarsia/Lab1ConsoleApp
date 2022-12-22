using Lab1ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class Adress : IID
    {

        public int ID { get; set; }
        public string StudentAdress { get; set; }
        public int StudentID { get; set; }

        public Adress(string studentAdress, int studentID)
        {
            StudentAdress = studentAdress;
            StudentID = studentID;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + StudentAdress + " " + StudentID);
        }
    }
}
