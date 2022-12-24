using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class DepartmentMenu
    {

        private SubjectCRUDMenu subjectCRUDMenu;
        private GroupSubjectCRUDMenu groupSubjectCRUDMenu;
        private Department department;

        public DepartmentMenu(SubjectCRUDMenu addressCRUDMenu, GroupSubjectCRUDMenu groupCRUDMenu, Department department)
        {
            this.subjectCRUDMenu = addressCRUDMenu;
            this.groupSubjectCRUDMenu = groupCRUDMenu;
            this.department = department;
        }

        public void Run()
        {
            bool flag = true;
            while(flag)
            {
                Console.Clear();
                Console.WriteLine("1. Subject CRUD");
                Console.WriteLine("2. GroupSubject CRUD");
                Console.WriteLine("3. GetGroupHoursAmount");
                Console.WriteLine("4. GetGroupSubject");
                Console.WriteLine("5. GetGroupStudent");
                Console.WriteLine("6. GetStudentGroupSubject");
                Console.WriteLine("7. GetStudent");
                Console.WriteLine("8. GetGroup");
                Console.WriteLine("9. Exit");
                int menuNumber = int.Parse(Console.ReadLine());
                switch(menuNumber)
                {
                    case 1:
                        subjectCRUDMenu.Run();
                        break;
                    case 2:
                        groupSubjectCRUDMenu.Run();
                        break;
                    case 3:
                        department.GetGroupHoursAmount();
                        Console.ReadKey();
                        break;
                    case 4:
                        department.GetGroupSubject();
                        Console.ReadKey();
                        break;
                    case 5:
                        department.GetGroupStudent();
                        Console.ReadKey();
                        break;
                    case 6:
                        department.GetStudentGroupSubject();
                        Console.ReadKey();
                        break;
                    case 7:
                        department.GetStudents();
                        Console.ReadKey();
                        break;
                    case 8:
                        department.GetGroups();
                        Console.ReadKey();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}
