﻿using ConsoleTables;

namespace Lab1ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB();
            HR hr = new HR(db);
            //hr.GetStudentAddressGroup();
            //hr.CreateStudent();
            //hr.GetGroups();
            //hr.GetStudents();
            //hr.GetGroupAmoutOfStudent();

            GroupCRUDMenu groupCRUDMenu = new GroupCRUDMenu(db.DBGroup);
            AddressCRUDMenu addressCRUDMenu = new AddressCRUDMenu(db.DBAddress);
            StudentCRUDMenu studentCRUDMenu = new StudentCRUDMenu(db.DBStudent);
            SubjectCRUDMenu subjectCRUDMenu = new SubjectCRUDMenu(db.DBSubject);
            GroupSubjectCRUDMenu groupSubjectCRUDMenu = new GroupSubjectCRUDMenu(db.DBGroupSubject);
            Department department = new Department();

            HRMenu hrMenu = new HRMenu(groupCRUDMenu, addressCRUDMenu, studentCRUDMenu, hr);
            DepartmentMenu departmentMenu = new DepartmentMenu(subjectCRUDMenu, groupSubjectCRUDMenu, department);

            MainMenu mainMenu = new MainMenu(hrMenu, departmentMenu);
            mainMenu.Run();
        }
    }
}



