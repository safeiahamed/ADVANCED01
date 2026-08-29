using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal class ClassTest<T> where T : class
    {
        
        public T Value { get; set; }
        public ClassTest(T value)
        {
            Value = value;
        }
    }
}
