using System;

namespace BoolAssmt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string yourAge = Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI? true or false");
            string yourDUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string yourTicks = Console.ReadLine();
            Console.WriteLine("Qualified?");
            int Age = Convert.ToInt32(yourAge);
            bool DUI = Convert.ToBoolean(yourDUI);
            int Tickets = Convert.ToInt32(yourTicks);

            if (Age > 15 && DUI == false && Tickets <= 3)
            {
                Console.WriteLine("true \n");
                Main();
            }
            else
            {
                Console.WriteLine("false \n");
                Main();
            }
        }
    }
}
