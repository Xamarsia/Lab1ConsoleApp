using database;
using menu;      
using hrDepartment;


class Program
{
    static void Main(string[] args)
    {
        DB db = new DB();
        HR hr = new HR(db);

        GroupCRUDMenu groupCRUDMenu = new GroupCRUDMenu(db.DBGroup);
        AddressCRUDMenu addressCRUDMenu = new AddressCRUDMenu(db.DBAddress);
        StudentCRUDMenu studentCRUDMenu = new StudentCRUDMenu(db.DBStudent);
        SubjectCRUDMenu subjectCRUDMenu = new SubjectCRUDMenu(db.DBSubject);
        GroupSubjectCRUDMenu groupSubjectCRUDMenu = new GroupSubjectCRUDMenu(db.DBGroupSubject);
        Department department = new Department(db);

        HRMenu hrMenu = new HRMenu(groupCRUDMenu, addressCRUDMenu, studentCRUDMenu, hr);
        DepartmentMenu departmentMenu = new DepartmentMenu(subjectCRUDMenu, groupSubjectCRUDMenu, department);

        MainMenu mainMenu = new MainMenu(hrMenu, departmentMenu);
        mainMenu.Run();
    }
}




