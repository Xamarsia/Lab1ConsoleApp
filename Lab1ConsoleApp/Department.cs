using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    public class Department : HRDeaprtment
    {
        DB db;

        public Department(DB db)
        {
            this.db = db;
        }

        public void GetStudentInformation()
        {
            var table = new ConsoleTable("Student", "Adress", "Group", "Subject");
            foreach (Student s in db.DBStudent.Items)
            {
                String student = s.getInfo();
                String adress = "";
                foreach (Adress a in db.DBAddress.Items)
                {
                    if (a.StudentID == s.ID)
                    {
                        adress = a.getInfo();
                    }
                }
                foreach (Group g in db.DBGroup.Items)
                {
                    if (g.ID == s.GroupID)
                    {
                        String group = g.getInfo();
                        foreach (GroupSubject gs in db.DBGroupSubject.Items)
                        {
                            if (gs.GroupID == g.ID)
                            {
                                foreach (Subject sub in db.DBSubject.Items)
                                {
                                    if (sub.ID == gs.SubjectID)
                                    {
                                        table.AddRow(student, adress, group,  sub.getInfo());
                                    }
                                }
                            }
                        }
                    }
                }
            }
            table.Write();
        }


        public void GetStudents()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Age");
            foreach (Student s in db.DBStudent.Items)
            {
                table.AddRow(s.ID, s.Name, s.Surname, s.Age);
            }
            table.Write();
        }
        public void GetGroups()
        {
            var table = new ConsoleTable("ID", "Group");
            foreach (Group g in db.DBGroup.Items)
            {
                table.AddRow(g.ID, g.GroupName);
            }
            table.Write();
        }

        public void GetStudentGroupSubject()
        {
            var table = new ConsoleTable("Group", "Student", "Subject");

            List<Student> students = db.DBStudent.Items;
            foreach (Student st in students)
            {
                String student = st.getInfo();
                String group = "";
                String subject = "";

                List<GroupSubject> groupSubject = db.DBGroupSubject.Items;
                List<Group> groups = db.DBGroup.Items;
                List<Subject> subjects = db.DBSubject.Items;
                foreach (GroupSubject gs in groupSubject)
                {
                    if (st.GroupID == gs.GroupID)
                    {
                        foreach (Group g in groups)
                        {
                            if (gs.GroupID == g.ID)
                            {
                                group = g.getInfo();
                            }
                        }

                        foreach (Subject s in subjects)
                        {
                            if (gs.SubjectID == s.ID)
                            {
                                subject = s.getInfo();
                                table.AddRow(group, student, subject);
                            }

                        }
                    }
                }
            }
            table.Write();
        }

        public void GetGroupStudent()
        {
            var table = new ConsoleTable("Group", "Student");

            List<Student> students = db.DBStudent.Items;
            foreach (Student s in students)
            {
                String student = s.getInfo();
                String group = "";

                List<Group> groups = db.DBGroup.Items;
                foreach (Group g in groups)
                {
                    if (s.GroupID == g.ID)
                    {
                        group = g.getInfo();
                    }
                }
                table.AddRow(group, student);
            }
            table.Write();
        }

        public void GetGroupAmoutOfStudent()
        {
            var table = new ConsoleTable("Group", "Amount of students");
            int summ = 0;
            foreach (Group g in db.DBGroup.Items)
            {
                foreach (Student s in db.DBStudent.Items)
                {
                    if (g.ID == s.GroupID)
                    {
                        summ++;
                    }
                }
                table.AddRow(g.getInfo(), summ);

                summ = 0;
            }
            table.Write();
        }

        public void GetGroupHoursAmount()
        {
            var table = new ConsoleTable("Group", "Number of subject hours");
         
            List<GroupSubject> groupSubject = db.DBGroupSubject.Items;
            List<Group> groups = db.DBGroup.Items;
            int summ = 0;

            foreach (Group g in groups)
            {
                foreach (GroupSubject gs in groupSubject)
                {
                    if(g.ID == gs.GroupID)
                    {
                        ++summ;
                    }
                }
                table.AddRow(g.getInfo(), summ);
                summ = 0;
            }
            table.Write();
        }

    

        public void GetGroupSubject()
        {
            var table = new ConsoleTable("Group", "Subject");

            String group = "";
            String subject = "";

            List<GroupSubject> groupSubject = db.DBGroupSubject.Items;
            List<Group> groups = db.DBGroup.Items;
            List<Subject> subjects = db.DBSubject.Items;
            foreach (GroupSubject gs in groupSubject)
            {
                foreach (Group g in groups)
                {
                    if (gs.GroupID == g.ID)
                    {
                        group = g.getInfo();
                    }
                }

                foreach (Subject s in subjects)
                {
                    if (gs.SubjectID == s.ID)
                    {
                        subject = s.getInfo();
                        table.AddRow(group, subject);
                    }

                }
                
            }
            
            table.Write();
        }

        public void GetStudentAddressGroup()
        {
            var table = new ConsoleTable("Student", "Adress", "Group");

            List<Student> students = db.DBStudent.Items;
            foreach (Student s in students)
            {
                String student = s.getInfo();
                String adress = "";
                String group = "";

                List<Adress> addresses = db.DBAddress.Items;
                foreach (Adress a in addresses)
                {
                    if (a.StudentID == s.ID)
                    {
                        adress = a.getInfo();
                    }
                }
                List<Group> groups = db.DBGroup.Items;
                foreach (Group g in groups)
                {
                    if (s.GroupID == g.ID)
                    {
                        group = g.getInfo();
                    }
                }
                table.AddRow(student, adress, group);
            }
            table.Write();
        }
    }
}
