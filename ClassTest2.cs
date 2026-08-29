using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AssignmentAdv_1
{
    internal class ClassTest2<T> where T : Container
    {
        public T Value { get; set; }
    }
}
