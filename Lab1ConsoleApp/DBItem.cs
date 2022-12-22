using System.Collections.Generic;
using Lab1ConsoleApp;
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
}