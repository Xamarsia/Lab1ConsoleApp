using System;
using Lab1ConsoleApp;
public class Adress : IId
{
	public int ID { get; set; }
	public string StudentAdress { get; set; }
	public string StudentID { get; set; }

	public Adress(string StudentAdress, string StudentID)
	{
		this.StudentAdress = StudentAdress;
		this.StudentID = StudentID;
	}

	public override string ToString()
	{
		return String.Format(ID + " " + StudentAdress + " " + StudentID);
	}
}
