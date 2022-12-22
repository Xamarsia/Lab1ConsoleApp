namespace Lab1ConsoleApp
{
	class Program
    {
        static void Main(string[] args)
        {
			DBItem<Group> dbGroup = new DBItem<Group>();
			Group group1 = new Group("PD-32");
			dbGroup.AddItem(group1);
			Group group2 = new Group("PD-33");
			dbGroup.AddItem(group2);

			DBItem<Student> dbStudent = new DBItem<Student>();
			Student student1 = new Student("Michael", "Fox", 18, 1);
			dbStudent.AddItem(student1);
			Student student2 = new Student("Johny", "Francesco", 21, 2);
			dbStudent.AddItem(student2);
			Student student3 = new Student("Lana", "Forbes", 20, 1);
			dbStudent.AddItem(student3);

			DBItem<Subject> dbSubject = new DBItem<Subject>();
			Subject subject1 = new Subject("Mathematics");
			dbSubject.AddItem(subject1);
			Subject subject2 = new Subject("English");
			dbSubject.AddItem(subject2);

			HR hr = new HR(dbGroup, dbStudent);
			//hr.CreateStudent();
			//hr.GetGroups();
			//hr.GetStudents();
			//hr.GetGroupAmoutOfStudent();

			GroupCRUDMenu groupCRUDMenu = new GroupCRUDMenu();
			AddressCRUDMenu addressCRUDMenu = new AddressCRUDMenu();
			StudentCRUDMenu studentCRUDMenu = new StudentCRUDMenu();
			SubjectCRUDMenu subjectCRUDMenu = new SubjectCRUDMenu();
			GroupSubjectCRUDMenu groupSubjectCRUDMenu = new GroupSubjectCRUDMenu();
			Department department = new Department();

			HRMenu hrMenu = new HRMenu(groupCRUDMenu, addressCRUDMenu, studentCRUDMenu, hr);
			DepartmentMenu departmentMenu = new DepartmentMenu(subjectCRUDMenu, groupSubjectCRUDMenu, department);

			MainMenu mainMenu = new MainMenu(hrMenu, departmentMenu);
			mainMenu.Run();

		}
	}
}
