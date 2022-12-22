using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class StudentCRUD : CRUD
    {
        public override void Create()
        {
            Console.WriteLine("\tStudent created!");
        }

        public override void Delete()
        {
            Console.WriteLine("\tStudent deleted!");
        }

        public override void Read()
        {
            Console.WriteLine("\tStudent readed!");
        }

        public override void Update()
        {
            Console.WriteLine("\tStudent updated!");
        }
    }
}
