using System;
using System.Collections.Generic;
using System.Text;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //NamedParam myClass = new NamedParam();

            Console.WriteLine("Please type an integer to multiply by 25");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please type another integer");
            int num2 = Convert.ToInt32(Console.ReadLine());

            NamedParam.Display(multiply: num1, display: num2);
        }
    }
}
