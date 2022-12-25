namespace model
{
	public class Group : IId
	{
		public int ID { get; set; }
		public string GroupName { get; set; }

		public Group(string GroupName)
		{
			this.GroupName = GroupName;
		}

		public override string ToString()
		{
			return String.Format(ID + " " + GroupName);
		}

		public string getInfo()
		{
			return GroupName;
		}
	}
}