namespace model
{
	public class Student : IId
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public int Age { get; set; }
		public int GroupID { get; set; }

		public Student(string Name, string Surname, int Age, int GroupID)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.Age = Age;
			this.GroupID = GroupID;
		}

		public override string ToString()
		{
			return String.Format(ID + " " + Name + " " + Surname + " " + Age + " " + GroupID);
		}

		public string getInfo()
		{
			return String.Format(Name + " " + Surname + " " + Age);
		}
	}
}