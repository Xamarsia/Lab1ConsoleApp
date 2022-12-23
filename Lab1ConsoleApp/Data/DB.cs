using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    public class DB
    {
        public DBItem<Group> DBGroup { get; set; } = new DBItem<Group>();
        public DBItem<Student> DBStudent { get; set; } = new DBItem<Student>();
        public DBItem<Subject> DBSubject { get; set; } = new DBItem<Subject>();
        public DBItem<Adress> DBAddress { get; set; } = new DBItem<Adress>();
        public DBItem<GroupSubject> DBGroupSubject { get; set; } = new DBItem<GroupSubject>();
        public DB()
        {
            Initialize();
        }
        private void Initialize()
        {
            GroupInitialize();
            StudentInitialize();
            SubjectInitialize();
            AddressInitialize();
            GroupSubjectInitialize();
        }
        private void GroupInitialize()
        {
            Group group1 = new Group("PD-32");
            DBGroup.AddItem(group1);
            Group group2 = new Group("PD-33");
            DBGroup.AddItem(group2);
        }
        private void StudentInitialize()
        {
            Student student1 = new Student("Michael", "Fox", 18, 1);
            DBStudent.AddItem(student1);
            Student student2 = new Student("Johny", "Francesco", 21, 2);
            DBStudent.AddItem(student2);
            Student student3 = new Student("Lana", "Forbes", 20, 1);
            DBStudent.AddItem(student3);
        }
        private void SubjectInitialize()
        {
            Subject subject1 = new Subject("Mathematics");
            DBSubject.AddItem(subject1);
            Subject subject2 = new Subject("English");
            DBSubject.AddItem(subject2);
        }
        private void AddressInitialize()
        {
            Adress address1 = new Adress("Address1", 2);
            DBAddress.AddItem(address1);
            Adress address2 = new Adress("Address2", 3);
            DBAddress.AddItem(address2);
            Adress address3 = new Adress("Address3", 1);
            DBAddress.AddItem(address3);
        }

         private void GroupSubjectInitialize()
         {
            GroupSubject GroupSubjec1 = new GroupSubject(1, 1);
            DBGroupSubject.AddItem(GroupSubjec1);
            GroupSubject GroupSubjec2 = new GroupSubject(1, 2);
            DBGroupSubject.AddItem(GroupSubjec2);
            GroupSubject GroupSubjec3 = new GroupSubject(2, 1);
            DBGroupSubject.AddItem(GroupSubjec3);
            GroupSubject GroupSubjec4 = new GroupSubject(2, 2);
            DBGroupSubject.AddItem(GroupSubjec4);
         }
    }
}
