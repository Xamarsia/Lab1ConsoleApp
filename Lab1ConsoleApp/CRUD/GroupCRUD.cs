using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            Console.WriteLine("Enter the Group ID to delete: ");
            int groupID = int.Parse(Console.ReadLine());
            bool deleted = false;

            foreach (Group a in DBGroup.Items)
            {
                if (a.ID == groupID)
                {
                    deleted = DBGroup.DeleteItem(a.ID);
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
            var table = new ConsoleTable("ID", "Group");
            foreach (Group g in DBGroup.Items)
            {
                table.AddRow(g.ID, g.GroupName);
            }
            table.Write();
        }

        public override void Update()
        {
            bool updated = false;
            Console.WriteLine("Enter the group ID to update: ");
            int groupID = int.Parse(Console.ReadLine());

            for (int i = 0; i < DBGroup.Items.Count; i++)
            {
                if(DBGroup.Items[i].ID == groupID)
                {
                    Console.Write("Write the name of the group to update: ");
                    string groupName = Console.ReadLine();
                    DBGroup.Items[i].GroupName = groupName;
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
