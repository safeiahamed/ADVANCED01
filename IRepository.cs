using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal interface IRepository<T>
    {
        public T Get(int ID);
        public void Set(int ID, T value);

    }
}
