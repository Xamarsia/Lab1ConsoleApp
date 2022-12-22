using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab1ConsoleApp
{
    class Department
    {

        DB db;

        public Department(DB db)
        {
            this.db = db;
        }

        public void GetStudentInformation()
        {
            foreach (Student s in db.dbStudent.Items)
            {
                Console.WriteLine(s);
                foreach (Adress a in db.dbAdress.Items)
                {
                    if (a.StudentID == s.ID)
                    {
                        Console.WriteLine("\t" + a);
                    }
                }
                foreach (Group g in db.dbGroup.Items)
                {
                    if (g.ID == s.GroupID)
                    {
                        Console.WriteLine("\t\t" + g);
                        foreach (GroupSubject gs in db.dbGroupSubject.Items)
                        {
                            if (gs.GroupID == g.ID)
                            {
                                foreach (Subject sub in db.dbSubject.Items)
                                {
                                    if (sub.ID == gs.SubjectID)
                                    {
                                        Console.WriteLine("\t\t\t" + sub);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
