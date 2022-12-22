using System;
using Lab1ConsoleApp;
public class GroupSubject : IId
{
	public int ID { get; set; }
	public string SubjectID { get; set; }
	public string GroupID { get; set; }

	public GroupSubject(string SubjectID, string GroupID)
	{
		this.SubjectID = SubjectID;
		this.GroupID = GroupID;
	}

	public override string ToString()
	{
		return String.Format(ID + " " + SubjectID + " " + GroupID);
	}
}
