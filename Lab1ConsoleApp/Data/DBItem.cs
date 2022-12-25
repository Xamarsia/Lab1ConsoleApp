namespace model
{
	public class DBItem<T> where T: IId
	{
		private int count = 1;
		public List<T> Items { get; set; }

		public DBItem()
		{
			this.Items = new List<T>();
		}

		public void AddItem(T item)
		{
			item.ID = count++;
			Items.Add(item);
		}

		public bool DeleteItem(int itemID)
		{
			if (Items.Count == 0 || itemID > count)
			{
				return false;
			} else
			{
				for (int i = 0; i < Items.Count; i++)
				{ 
					if (Items[i].ID == itemID) {
						Items.RemoveAt(i);
						return true;
					}
				}	
			}
			return false;
		}
	}
}
