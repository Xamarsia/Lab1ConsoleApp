﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class StudentCRUDMenu
    {

        StudentCRUD studentCRUD = new StudentCRUD();

        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                int menuNumber = int.Parse(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        studentCRUD.Create();
                        break;
                    case 2:
                        studentCRUD.Read();
                        break;
                    case 3:
                        studentCRUD.Update();
                        break;
                    case 4:
                        studentCRUD.Delete();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
