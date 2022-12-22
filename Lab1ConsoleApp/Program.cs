using System;

namespace Lab1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            Department department = new Department(db);
            department.GetStudentInformation();
        }
    }
}
