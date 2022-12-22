using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class Group : IID
    {

        public int ID { get; set; }
        public string GroupName { get; set; }

        public Group(string groupName)
        {
            GroupName = groupName;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + GroupName);
        }
    }
}
