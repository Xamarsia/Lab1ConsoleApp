using CRUD;
using model;

namespace menu
{
    public class AddressCRUDMenu
    {
        AddressCRUD addressCRUD;
        public AddressCRUDMenu(DBItem<Adress> dBAddress)
        {
            addressCRUD = new AddressCRUD(dBAddress);
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
                        addressCRUD.Create();
                        break;
                    case 2:
                        addressCRUD.Read();;
                        break;
                    case 3:
                        addressCRUD.Update();
                        break;
                    case 4:
                        addressCRUD.Delete();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }

    }
}
