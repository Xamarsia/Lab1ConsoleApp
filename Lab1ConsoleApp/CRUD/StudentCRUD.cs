using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class StudentCRUD : CRUD
    {
        DBItem<Student> DBStudent;
        public StudentCRUD(DBItem<Student> dBStudent)
        {
            DBStudent = dBStudent;
        }

        public override void Create()
        {
            Console.Write("Name?: ");
            string name = Console.ReadLine();
            Console.Write("Surname?: ");
            string surname = Console.ReadLine();
            Console.Write("Age?: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("GroupID?: ");
            int groupID = int.Parse(Console.ReadLine());
            Student student = new Student(name, surname, age, groupID);
            DBStudent.AddItem(student);
        }

        public override void Delete()
        {
            Console.Write("Enter the student ID to delete: ");
            int studentID = int.Parse(Console.ReadLine());
        }

        public override void Read()
        {
            var table = new ConsoleTable("ID", "Name", "Surname", "Age");
            foreach (Student s in DBStudent.Items)
            {
                table.AddRow(s.ID, s.Name, s.Surname, s.Age);
            }
            table.Write();
        }

        public override void Update()
        {
        }
    }
}
