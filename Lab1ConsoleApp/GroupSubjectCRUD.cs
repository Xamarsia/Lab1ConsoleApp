using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class GroupSubjectCRUD : CRUD
    {
        public override void Create()
        {
            Console.WriteLine("\tGroupSubject created!");
        }

        public override void Delete()
        {
            Console.WriteLine("\tGroupSubject deleted!");
        }

        public override void Read()
        {
            Console.WriteLine("\tGroupSubject readed!");
        }

        public override void Update()
        {
            Console.WriteLine("\tGroupSubject update!");
        }
    }
}
