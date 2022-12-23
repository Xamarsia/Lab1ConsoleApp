using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class GroupCRUD : CRUD
    {
        DBItem<Group> DBGroup;
        public GroupCRUD(DBItem<Group> dBGroup)
        {
            DBGroup = dBGroup;
        }

        public override void Create()
        {
            Console.Write("Group Name?: ");
            string groupName = Console.ReadLine();

            Group group = new Group(groupName);
            DBGroup.AddItem(group);
        }

        public override void Delete()
        {

        }

        public override void Read()
        {
            var table = new ConsoleTable("ID", "Group");
            foreach (Group g in DBGroup.Items)
            {
                table.AddRow(g.ID, g.GroupName);
            }
            table.Write();
        }

        public override void Update()
        {

        }
    }
}
