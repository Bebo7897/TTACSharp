using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmission
{
    public class SimpleMath
    {
        public void Divide(int numerator, out int timesUsed)
        {
            timesUsed = 0;
            timesUsed++;
            numerator = numerator / 2;
            Console.WriteLine(numerator);
        }

        public void Divide(decimal numerator)
        {
            numerator = numerator / 3;
            Console.WriteLine(numerator);
        }
    }
}
