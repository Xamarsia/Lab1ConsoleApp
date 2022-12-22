using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class GroupSubject : IID
    {

        public int ID { get; set; }
        public int GroupID { get; set; }
        public int SubjectID { get; set; }

        public GroupSubject(int groupID, int subjectID)
        {
            GroupID = groupID;
            SubjectID = subjectID;
        }

        public override string ToString()
        {
            return String.Format(ID + " " + GroupID + " " + SubjectID);
        }
    }
}
