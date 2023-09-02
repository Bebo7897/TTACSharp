using System;

namespace MainMethodAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTEGER
            Console.WriteLine("Type an integer to multiply by 3");
            int multThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your integer multiplied by 3 equals " + MathOverload.Multiplication(multThree));

            //DECIMAL
            Console.WriteLine("Type a decimal to multiply by 10");
            decimal multTen = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Your decimal multiplied by 10 equals " + MathOverload.Multiplication(multTen));

            //STRING
            Console.WriteLine("Type a whole number to multiply by 25");
            string multTwFive = Console.ReadLine();
            Console.WriteLine("Your number multiplied by 25 equals " + MathOverload.Multiplication(multTwFive));
        }
    }
}
