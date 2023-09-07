using System;
using System.Collections.Generic;

namespace GenericParam
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() { "pen", "desk", "printer", "computer" };

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>() { 5, 15, 22, 59 };

            foreach (string thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\n");

            foreach (int thing in employee1.things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
