using ConsoleTables;
using model;

namespace CRUD
{
    class GroupSubjectCRUD : CRUD
    {
        DBItem<GroupSubject> DBGroupSubject;
        public GroupSubjectCRUD(DBItem<GroupSubject> dBGroupSubject)
        {
            DBGroupSubject = dBGroupSubject;
        }

        public override void Create()
        {
            Console.Write("Subject ID?: ");
            int subjectID = int.Parse(Console.ReadLine());
            Console.Write("Group ID?: ");
            int groupID = int.Parse(Console.ReadLine());
            GroupSubject groupSubject = new GroupSubject(subjectID, groupID);

            DBGroupSubject.AddItem(groupSubject);
        }

        public override void Delete()
        {
            Console.WriteLine("Enter the GroupSubject ID to delete: ");
            int groupSubjectID = int.Parse(Console.ReadLine());
            bool deleted = false;

            foreach (GroupSubject a in DBGroupSubject.Items)
            {
                if (a.ID == groupSubjectID)
                {
                    deleted = DBGroupSubject.DeleteItem(a.ID);
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
            var table = new ConsoleTable("ID", "Subject ID", "Group ID");
            foreach (GroupSubject g in DBGroupSubject.Items)
            {
                table.AddRow(g.ID, g.SubjectID, g.GroupID);
            }
            table.Write();
        }

        public override void Update()
        {
            bool updated = false;

            Console.WriteLine("Enter the GroupSubject ID to update: ");
            int groupSubjectID = int.Parse(Console.ReadLine());


            for (int i = 0; i < DBGroupSubject.Items.Count; i++)
            {
                if(DBGroupSubject.Items[i].ID == groupSubjectID)
                {
                    Console.WriteLine("Enter the group ID to update: ");
                    int groupID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the subject ID to update: ");
                    int subjectID = int.Parse(Console.ReadLine());

                    DBGroupSubject.Items[i].GroupID = groupID;
                    DBGroupSubject.Items[i].SubjectID = subjectID;
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
