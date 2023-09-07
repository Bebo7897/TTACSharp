using System;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Jon", lastName = "Snow", ID = 1 };
            Employee employee2 = new Employee() { firstName = "Rob", lastName = "Stark", ID = 2 };

            if (employee == employee2)
            {
                Console.WriteLine("These employees have matching IDs");
            }
            else
            {
                Console.WriteLine("These employees do not have matching IDs");
            }
            
        }
    }
}
