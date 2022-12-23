using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1ConsoleApp
{
    abstract class CRUD
    {
        //abstract class CRUD<T, D> where T : DBItem<D> where D : IId
        public abstract void Create();
        public abstract void Read();
        public abstract void Update();
        public abstract void Delete();

    }
}
