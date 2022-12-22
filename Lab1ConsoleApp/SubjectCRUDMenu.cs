using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1ConsoleApp
{
    internal class SubjectCRUDMenu
    {
        SubjectCRUD subjectCRUD = new SubjectCRUD();

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
                        subjectCRUD.Create();
                        break;
                    case 2:
                        subjectCRUD.Read();
                        break;
                    case 3:
                        subjectCRUD.Update();
                        break;
                    case 4:
                        subjectCRUD.Delete();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
