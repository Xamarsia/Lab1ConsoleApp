using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    class DBItem<T> where T : IID
    {

        public List<T> Items { get; set; }
        private int counter = 1;

        public DBItem()
        {
            Items = new List<T>();
        }

        public void AddItem(T item)
        {
            item.ID = counter++;
            Items.Add(item);
        }
    }
}
