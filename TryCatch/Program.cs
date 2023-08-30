using System;
using System.Collections.Generic;

namespace TryCatch
{
    class Program
    {
        static void Main()
        {
            List<int> divisors = new List<int> { 20, 40, 60, 80, 100 };

            Console.WriteLine("Enter an integer to divide into 20, 40, 60, 80, and 100");
            
            try
            {
                int userNum = Convert.ToInt32(Console.ReadLine());

                foreach (int divisor in divisors)
                {
                    int solution = divisor / userNum;
                    Console.WriteLine("\n"+ divisor + " divided by " + userNum + " equals " + solution);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please only enter whole numbers");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("\nLet's try again!\n");
            }

            Main();
        }
    }
}
