using System;

namespace ParsingEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week.");
            
            try
            {
                string Day = Console.ReadLine();

                DaysofWeek day = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), Day);
                Console.WriteLine("The day you typed, " + day + ", is a correct day of the week!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an actual day of the week!");
            }
            
        }
    }

    public enum DaysofWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
