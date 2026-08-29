using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal class SafeList<T>
    {
        private List<T> values=new List<T>();
        public void Add(T value)
        {
            values.Add(value);
        }

        public T GetById(int id)
        {
            if (id < 0) return default;
            return values[id];

        }

    }
}
