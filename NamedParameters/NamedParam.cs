using System;
using System.Collections.Generic;
using System.Text;

namespace NamedParameters
{
    public class NamedParam
    {
        public static void Display(int multiply, int display)
        {
            multiply = multiply * 25;
            Console.WriteLine(display);
        }
    }
}
