using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAdv_1
{
    internal class StructTest<T> where T : struct
    {
        public T Value { get; set; }
        public StructTest(T value)
        { 
            Value = value;
        }
    }
}
