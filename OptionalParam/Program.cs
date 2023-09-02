using System;

namespace OptionalParam
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's multiply! Maybe...\nEnter the first number for multiplication!");
            int num1 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Enter a second number to multiply the first by or leave blank to multiply by 1");
            string numString = Console.ReadLine();

            if (numString == "")
            {
                Console.WriteLine("Your numbers multiplied together equals " + OptionalParam.Multiple(num1));
            }
            else
            {
                int num2 = Convert.ToInt32(numString);
                Console.WriteLine("Your numbers multiplied together equals " + OptionalParam.Multiple(num1,num2));
            }
        }
    }
}
