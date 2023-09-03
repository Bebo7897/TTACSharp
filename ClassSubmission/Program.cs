using System;

namespace ClassSubmission
{
    class Program
    {
        static void Main()
        {
            SimpleMath myMath = new SimpleMath();
            int timesUsed = 0;

            Console.WriteLine("Please enter a whole number to cut in half");
            int half = Convert.ToInt32(Console.ReadLine());
            myMath.Divide(half, out timesUsed);
            Console.WriteLine(timesUsed);

            Console.WriteLine("Please enter a decimal number to cut into a third");
            decimal third = Convert.ToInt32(Console.ReadLine());
            myMath.Divide(third);
        }
    }
}
