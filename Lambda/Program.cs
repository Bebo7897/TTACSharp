using System;
using System.Collections.Generic;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            // Step 1
            List<string> employees = new List<string>() { "Joe Smith", "Peter Parker", "Clark Kent", "Frank Castle", "Joe Jones",
                                                        "Tony Stark", "Natasha Romanoff", "Clint Barton", "Bruce Wayne", "Joe Ross"};

            Employee employee1 = new Employee() { firstName = "Peter", lastName = "Parker", ID = 7 };
            Employee employee2 = new Employee() { firstName = "Clark", lastName = "Kent", ID = 2 };
            Employee employee3 = new Employee() { firstName = "Frank", lastName = "Castle", ID = 10 };
            Employee employee4 = new Employee() { firstName = "Clint", lastName = "Barton", ID = 6 };
            Employee employee5 = new Employee() { firstName = "Bruce", lastName = "Wayne", ID = 1 };
            Employee employee6 = new Employee() { firstName = "Joe", lastName = "Jones", ID = 8 };
            Employee employee7 = new Employee() { firstName = "Joe", lastName = "Smith", ID = 3 };

            List<Employee> employees1 = new List<Employee>();
            employees1.Add(employee1);
            employees1.Add(employee2);
            employees1.Add(employee3);
            employees1.Add(employee4);
            employees1.Add(employee5);
            employees1.Add(employee6);
            employees1.Add(employee7);

            //foreach (Employee employeeHero in employees1)
            //{
            //    Console.WriteLine(employeeHero.firstName + employeeHero.lastName + employeeHero.ID);
            //}


            List<string> joes = new List<string>();

            Console.WriteLine("Step 2");

            foreach (string employee in employees)
            {
                if (employee.Contains("Joe"))
                {
                    joes.Add(employee);
                    Console.WriteLine(employee);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Step 3");

            List<Employee> Joes = employees1.FindAll(x => x.firstName == "Joe");

            foreach (Employee Joe in Joes)
            {
                Console.WriteLine(Joe.firstName + " " + Joe.lastName);
            }

            Console.WriteLine("\n");
            Console.WriteLine("Step 4");

            List<Employee> IDs = employees1.FindAll(x => x.ID > 5);

            foreach (Employee id in IDs)
            {
                Console.WriteLine(id.firstName + " " + id.lastName + " " + id.ID);
            }
        }
    }
}
