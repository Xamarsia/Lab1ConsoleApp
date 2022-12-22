﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class GroupSubjectCRUDMenu
    {

        GroupSubjectCRUD groupSubjectCRUD = new GroupSubjectCRUD();

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
                        groupSubjectCRUD.Create();
                        break;
                    case 2:
                        groupSubjectCRUD.Read();
                        break;
                    case 3:
                        groupSubjectCRUD.Update();
                        break;
                    case 4:
                        groupSubjectCRUD.Delete();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }

    }
}
