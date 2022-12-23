using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class SubjectCRUD : CRUD
    {
        DBItem<Subject> DBSubject;
        public SubjectCRUD(DBItem<Subject> dBSubject)
        {
            DBSubject = dBSubject;
        }

        public override void Create()
        {
            Console.Write("Subject Name? : ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(subjectName);
            DBSubject.AddItem(subject);
        }

        public override void Delete()
        {
        }

        public override void Read()
        {
        }

        public override void Update()
        {
        }
    }
}
