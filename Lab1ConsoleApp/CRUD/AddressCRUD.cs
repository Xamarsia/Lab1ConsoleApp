using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab1ConsoleApp
{
    class AddressCRUD : CRUD
    {
        DBItem<Adress> DBAdressp;
        public AddressCRUD(DBItem<Adress> dBAdressp)
        {
            DBAdressp = dBAdressp;
        }

        public override void Create()
        {
            Console.Write("Student Adress?: ");
            string studentAdress = Console.ReadLine();

            Console.Write("Student ID?: ");
            int studentID = int.Parse(Console.ReadLine());

            Adress adress = new Adress(studentAdress, studentID);
            DBAdressp.AddItem(adress);
        }

        public override void Delete()
        {
            Console.WriteLine("Enter the address to delete: ");
            string adres = Console.ReadLine();

            bool deleted = false;

            foreach (Adress a in DBAdressp.Items)
            {
                if (a.StudentAdress == adres)
                {
                    deleted = DBAdressp.DeleteItem(a.ID);
                }
            }

            if (deleted)
            {
                Console.WriteLine("Removal successful");
            } else
            {
                Console.WriteLine("This ID does not exist");
            }
        }

        public override void Read()
        {
            var table = new ConsoleTable("ID", "StudentAdress", "StudentID");
            foreach (Adress a in DBAdressp.Items)
            {
                table.AddRow(a.ID, a.StudentAdress, a.StudentID);
            }
            table.Write();
        }

        public override void Update()
        {
            Console.WriteLine("Enter the address ID to update: ");
            int addressID = int.Parse(Console.ReadLine());
            for(int i = 0; i < DBAdressp.Items.Count; i ++)
            {
                DBAdressp.Items[i].ID = addressID;
                Console.Write("Write the student's address to update: ");
                string studentAdress = Console.ReadLine();

                Console.Write("Write the student's ID to update: ");
                int studentID = int.Parse(Console.ReadLine());
            }

        }
    }
}
