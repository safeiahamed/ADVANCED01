using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal class Container<T>
    {
        public T Item;
        public void Add(T item) 
        {
            Item = item;
        }
        public T Get()
        {
            return Item;
        }
    }
}
