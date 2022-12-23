using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
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
        }

        public override void Read()
        {
        }

        public override void Update()
        {
        }
    }
}
