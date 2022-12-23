using System;
using Lab1ConsoleApp;
using System.Collections.Generic;
using ConsoleTables;

public class HR : HRDeaprtment
{
	DB db;
	public HR(DB db)
	{
		this.db = db;
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
	public void CreateStudent()
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
		db.DBStudent.AddItem(student);
    }
	public void GetStudents()
	{
        var table = new ConsoleTable("Name", "Surname", "Age");
        foreach (Student s in db.DBStudent.Items)
		{
            table.AddRow(s.Name, s.Surname, s.Age);
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

	public void GetStudentAddressGroup()
    {
        var table = new ConsoleTable("Student", "Adress", "Group");

        List<Student> students = db.DBStudent.Items;
		foreach(Student s in students)
        {
			String student = s.getInfo();
            String adress = "";
            String group = "";

			List<Adress> addresses = db.DBAddress.Items;
			foreach(Adress a in addresses)
            {
				if(a.StudentID == s.ID)
                {
                    adress = a.getInfo();
                }
            }
			List<Group> groups = db.DBGroup.Items;
			foreach(Group g in groups)
            {
				if(s.GroupID == g.ID)
                {
                    group = g.getInfo();
                }
            }
			table.AddRow(student, adress, group);
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
                if(st.GroupID == gs.GroupID)
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
}
