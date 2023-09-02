using System;

namespace MethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            //Half
            Console.WriteLine("Please enter the number you want to half");
            int halfNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Half of your number is " + SimpleMath.Half(halfNum) + "\n");

            //Double
            Console.WriteLine("Please enter the number you want to double");
            int dubNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Double your number is " + SimpleMath.Double(dubNum) + "\n");

            //Square
            Console.WriteLine("Please enter the number you want to square");
            int sqNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number squared is " + SimpleMath.Square(sqNum) + "\n");
        }
    }
}
