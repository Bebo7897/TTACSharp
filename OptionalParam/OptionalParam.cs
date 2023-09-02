using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalParam
{
    class OptionalParam
    {
        public static int Multiple(int num1, int num2 = 1)
        {
            int num3 = num1 * num2;
            return num3;
        }
    }
}
