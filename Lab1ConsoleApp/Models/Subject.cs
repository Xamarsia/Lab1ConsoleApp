using System;
using Lab1ConsoleApp;

public class Subject:IId
{
	public int ID { get; set; }
	public string SubjectName { get; set; }

	public Subject(string SubjectName)
	{
		this.SubjectName = SubjectName;
	}

	public override string ToString()
	{
		return String.Format(ID + " " + SubjectName);
	}

    public string getInfo()
    {
        return String.Format(SubjectName);
    }

}
