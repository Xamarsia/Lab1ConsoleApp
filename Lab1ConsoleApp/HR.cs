using System;
using Lab1ConsoleApp;
public class HR 
{
	DBItem<Group> dbGroup;
	DBItem<Student> dbStudent;

	public HR(DBItem<Group> dbGroup, DBItem<Student> dbStudent)
	{
		this.dbGroup = dbGroup;
		this.dbStudent = dbStudent;
	}
	public void GetGroupAmoutOfStudent()
	{
		int summ = 0;
		foreach (Group g in dbGroup.Items)
		{
			Console.Write(g);
			foreach (Student s in dbStudent.Items)
			{
				if (g.ID == s.GroupID)
				{
					summ++;
				}
			}
			Console.WriteLine(" " + summ);
			summ = 0;
		}
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
		dbStudent.AddItem(student);
    }
	public void GetStudents()
	{
		foreach (Student s in dbStudent.Items)
		{
			Console.WriteLine(s);
		}
	}
	public void GetGroups()
	{
		foreach (Group g in dbGroup.Items)
		{
			Console.WriteLine(g);
		}
	}
}
