using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class MainMenu
    {

        private HRMenu hrMenu;
        private DepartmentMenu departmentMenu;

        public MainMenu(HRMenu hrMenu, DepartmentMenu departmentMenu)
        {
            this.hrMenu = hrMenu;
            this.departmentMenu = departmentMenu;
        }

        public void Run()
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1. HR");
                Console.WriteLine("2. Deparment");
                Console.WriteLine("3. Exit");
                int menuNumber = int.Parse(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        hrMenu.Run();
                        break;
                    case 2:
                        departmentMenu.Run();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
