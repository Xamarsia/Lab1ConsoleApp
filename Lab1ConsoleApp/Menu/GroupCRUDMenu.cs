using CRUD;
using model;

namespace menu
{
    public class GroupCRUDMenu
    {

        GroupCRUD groupCRUD;
        public GroupCRUDMenu(DBItem<Group> dBGroup)
        {
            groupCRUD = new GroupCRUD(dBGroup);
        }
        
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
                        groupCRUD.Create();
                        break;
                    case 2:
                        groupCRUD.Read();
                        break;
                    case 3:
                        groupCRUD.Update();
                        break;
                    case 4:
                        groupCRUD.Delete();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
