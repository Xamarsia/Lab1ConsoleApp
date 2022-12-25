using hrDepartment;

namespace menu
{
    class HRMenu
    {

        private GroupCRUDMenu groupCRUDMenu;
        private AddressCRUDMenu addressCRUDMenu;
        private StudentCRUDMenu studentCRUDMenu;
        private HR hr;

        public HRMenu(GroupCRUDMenu groupCRUDMenu, AddressCRUDMenu addressCRUDMenu, StudentCRUDMenu studentCRUDMenu, HR hr)
        {
            this.groupCRUDMenu = groupCRUDMenu;
            this.addressCRUDMenu = addressCRUDMenu;
            this.studentCRUDMenu = studentCRUDMenu;
            this.hr = hr;
        }

        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("1. Group CRUD");
                Console.WriteLine("2. Address CRUD");
                Console.WriteLine("3. Student CRUD");
                Console.WriteLine("4. GetStudentAddressGroup");
                Console.WriteLine("5. GetGroupAmouintOfStudent");
                Console.WriteLine("6. GetGroupStudent");
                Console.WriteLine("7. GetStudentGroupSubject");
                Console.WriteLine("8. GetStudent");
                Console.WriteLine("9. GetGroup");
                Console.WriteLine("10. Exit");
                int menuNumber = int.Parse(Console.ReadLine());
                switch (menuNumber)
                {
                    case 1:
                        groupCRUDMenu.Run();
                        break;
                    case 2:
                        addressCRUDMenu.Run();
                        break;
                    case 3:
                        studentCRUDMenu.Run();
                        break;
                    case 4:
                        hr.GetStudentAddressGroup();
                        Console.ReadKey();
                        break;
                    case 5:
                        hr.GetGroupAmoutOfStudent();
                        Console.ReadKey();
                        break;
                    case 6:
                        hr.GetGroupStudent();
                        Console.ReadKey();
                        break;
                    case 7:
                        hr.GetStudentGroupSubject();
                        Console.ReadKey();
                        break;
                    case 8:
                        hr.GetStudents();
                        Console.ReadKey();
                        break;
                    case 9:
                        hr.GetGroups();
                        Console.ReadKey();
                        break;
                    case 10:
                        flag = false;
                        break;
                }
            }
        }

    }
}
