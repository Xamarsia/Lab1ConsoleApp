using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class GroupCRUD : CRUD
    {
        public override void Create()
        {
            Console.WriteLine("\tGroup created!");
        }

        public override void Delete()
        {
            Console.WriteLine("\tGroup deleted!");
        }

        public override void Read()
        {
            Console.WriteLine("\tGroup readed!");
        }

        public override void Update()
        {
            Console.WriteLine("\tGroup updated!");
        }
    }
}
