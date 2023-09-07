using System;
using System.Collections.Generic;
using System.Text;

namespace GenericParam
{
    public class Employee<T>
    {
        public List<T> things { get; set; }
    }
}
