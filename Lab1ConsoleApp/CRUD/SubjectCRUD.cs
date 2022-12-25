using ConsoleTables;
using model;

namespace CRUD
{
    class SubjectCRUD : CRUD
    {
        DBItem<Subject> DBSubject;
        public SubjectCRUD(DBItem<Subject> dBSubject)
        {
            DBSubject = dBSubject;
        }

        public override void Create()
        {
            Console.Write("Subject Name? : ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(subjectName);
            DBSubject.AddItem(subject);
        }

        public override void Delete()
        {
            Console.Write("Enter the subject ID to delete: ");
            int subjectID = int.Parse(Console.ReadLine());
            bool deleted = false;

            foreach (Subject a in DBSubject.Items)
            {
                if (a.ID == subjectID)
                {
                    deleted = DBSubject.DeleteItem(a.ID);
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
            var table = new ConsoleTable("ID", "SubjectName");
            foreach (Subject s in DBSubject.Items)
            {
                table.AddRow(s.ID, s.SubjectName);
            }
            table.Write();
        }

        public override void Update()
        {
            bool updated = false;

            Console.WriteLine("Enter the Subject ID to update: ");
            int subjectID = int.Parse(Console.ReadLine());


            for (int i = 0; i < DBSubject.Items.Count; i++)
            {
                if (DBSubject.Items[i].ID == subjectID)
                {
                    Console.Write("Enter the Subject Name to update: ");
                    string name = Console.ReadLine();

                    DBSubject.Items[i].SubjectName = name;
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
