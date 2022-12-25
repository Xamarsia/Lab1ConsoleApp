using ConsoleTables;
using model;

namespace CRUD
{
    class StudentCRUD : CRUD
    {
        DBItem<Student> DBStudent;
        public StudentCRUD(DBItem<Student> dBStudent)
        {
            DBStudent = dBStudent;
        }

        public override void Create()
        {
            Console.Write("Name?: ");
            string name = Console.ReadLine();
            Console.Write("Surname?: ");
            string surname = Console.ReadLine();
            Console.Write("Age?: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("GroupID?: ");
            int groupID = int.Parse(Console.ReadLine());
            Student student = new Student(name, surname, age, groupID);
            DBStudent.AddItem(student);
        }

        public override void Delete()
        {
            Console.Write("Enter the student ID to delete: ");
            int studentID = int.Parse(Console.ReadLine());
            bool deleted = false;

            foreach (Student a in DBStudent.Items)
            {
                if (a.ID == studentID)
                {
                    deleted = DBStudent.DeleteItem(a.ID);
                    break;
                }
            }

            if (deleted)
            {
                Console.WriteLine("Removal successful");
            }
            else
            {
                Console.WriteLine("This ID does not exist");
            }
        }

        public override void Read()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Age");
            foreach (Student s in DBStudent.Items)
            {
                table.AddRow(s.ID, s.Name, s.Surname, s.Age);
            }
            table.Write();
        }

        public override void Update()
        {
            bool updated = false;

            Console.WriteLine("Enter the student ID to update: ");
            int studentID = int.Parse(Console.ReadLine());


            for (int i = 0; i < DBStudent.Items.Count; i++)
            {
                if (DBStudent.Items[i].ID == studentID)
                {
                    Console.Write("Enter the Name to update: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter the Surname to update:  ");
                    string surname = Console.ReadLine();

                    Console.Write("Enter the Age to update: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter the GroupID to update: ");
                    int groupID = int.Parse(Console.ReadLine());


                    DBStudent.Items[i].Name = name;
                    DBStudent.Items[i].Surname = surname;
                    DBStudent.Items[i].Age = age;
                    DBStudent.Items[i].GroupID = groupID;
                    updated = true;
                }
            }
            if (updated)
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("This ID does not exist");
            }
        }
    }
}
