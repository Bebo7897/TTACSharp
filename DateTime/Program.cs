using System;
using System.IO;

namespace DateTimeAssmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;

            //print Now
            Console.WriteLine(dateTime);

            //Take in Hours to add
            Console.WriteLine("Please enter a whole number of hours to add to current time");
            double hours = Convert.ToInt32(Console.ReadLine());
         
            //Print now plus hours entered
            Console.WriteLine(dateTime.AddHours(hours));
        }
    }
}
