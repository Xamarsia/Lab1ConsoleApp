using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class AddressCRUD : CRUD
    {
        public override void Create()
        {
            Console.WriteLine("\tAddress created!");
        }

        public override void Delete()
        {
            Console.WriteLine("\tAddress deleted!");
        }

        public override void Read()
        {
            Console.WriteLine("\tAddress readed!");
        }

        public override void Update()
        {
            Console.WriteLine("\tAddress updated!");
        }
    }
}
