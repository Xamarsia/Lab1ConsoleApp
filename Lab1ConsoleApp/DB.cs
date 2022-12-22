using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab1ConsoleApp
{
    class DB
    {

        public DBItem<Student> dbStudent { get; set; }
        public DBItem<Group> dbGroup { get; set; }
        public DBItem<Adress> dbAdress { get; set; }
        public DBItem<Subject> dbSubject { get; set; }
        public DBItem<GroupSubject> dbGroupSubject { get; set; }

        public DB()
        {
            GenerateDBAdress();
            GenerateDBGroup();
            GenerateDBGroupSubject();
            GenerateDBStudent();
            GenerateDBSubject();
        }

        private void GenerateDBStudent()
        {
            dbStudent = new DBItem<Student>();
            Student student1 = new Student("Taras", "Shevchenko", 19, 1);
            dbStudent.AddItem(student1);
            Student student2 = new Student("Ivan", "Franko", 20, 1);
            dbStudent.AddItem(student2);
            Student student3 = new Student("Lesya", "Ukrainka", 19, 2);
            dbStudent.AddItem(student3);
        }

        private void GenerateDBGroup()
        {
            dbGroup = new DBItem<Group>();
            Group group1 = new Group("PD-33");
            dbGroup.AddItem(group1);
            Group group2 = new Group("PD-34");
            dbGroup.AddItem(group2);
        }

        private void GenerateDBAdress()
        {
            dbAdress = new DBItem<Adress>();
            Adress adress1 = new Adress("Kyiv", 2);
            dbAdress.AddItem(adress1);
            Adress adress2 = new Adress("Odesa", 3);
            dbAdress.AddItem(adress2);
            Adress adress3 = new Adress("Lviv", 1);
            dbAdress.AddItem(adress3);
        }

        private void GenerateDBSubject()
        {
            dbSubject = new DBItem<Subject>();
            Subject subject1 = new Subject("Modeling", 100);
            dbSubject.AddItem(subject1);
            Subject subject2 = new Subject("Proecting", 200);
            dbSubject.AddItem(subject2);
            Subject subject3 = new Subject("C#", 300);
            dbSubject.AddItem(subject3);
        }

        private void GenerateDBGroupSubject()
        {
            dbGroupSubject = new DBItem<GroupSubject>();
            GroupSubject groupSubject1 = new GroupSubject(1, 1);
            dbGroupSubject.AddItem(groupSubject1);
            GroupSubject groupSubject2 = new GroupSubject(1, 2);
            dbGroupSubject.AddItem(groupSubject2);
            GroupSubject groupSubject3 = new GroupSubject(2, 1);
            dbGroupSubject.AddItem(groupSubject3);
            GroupSubject groupSubject4 = new GroupSubject(2, 3);
            dbGroupSubject.AddItem(groupSubject4);
        }
    }
}
