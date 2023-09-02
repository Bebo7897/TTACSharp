using System;
using System.Collections.Generic;
using System.Text;

namespace MainMethodAssmt
{
    class MathOverload
    {
        public static int Multiplication(int multi)
        {
            multi = multi * 3;
            return multi;
        }

        public static int Multiplication(decimal multi)
        {
            multi = multi * 10;
            return Convert.ToInt32(multi);
        }

        public static int Multiplication(string multi)
        {
            int numMulti = Convert.ToInt32(multi);
            numMulti = numMulti * 25;
            return numMulti;
        }
    }
}
