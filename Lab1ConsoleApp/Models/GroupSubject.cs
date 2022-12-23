using System;
using Lab1ConsoleApp;
public class GroupSubject : IId
{
	public int ID { get; set; }
	public int SubjectID { get; set; }
	public int GroupID { get; set; }

	public GroupSubject(int SubjectID, int GroupID)
	{
		this.SubjectID = SubjectID;
		this.GroupID = GroupID;
	}

	public override string ToString()
	{
		return String.Format(ID + " " + SubjectID + " " + GroupID);
	}
}
