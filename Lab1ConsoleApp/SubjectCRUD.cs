using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class SubjectCRUD : CRUD
    {
        public override void Create()
        {
            Console.WriteLine("\tSubject created!");
        }

        public override void Delete()
        {
            Console.WriteLine("\tSubject deleted!");
        }

        public override void Read()
        {
            Console.WriteLine("\tSubject readed!");
        }

        public override void Update()
        {
            Console.WriteLine("\tSubject updated!");
        }
    }
}
