using System;

namespace BranchingAssmt
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \nPackage Weight?");
            decimal packWeight = Convert.ToDecimal(Console.ReadLine());

            //determine whether package is too heavy
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.\n");
                Main();
            }
            else
            {
                Console.WriteLine("Package width?");
            }
            //width
            decimal packWidth = Convert.ToDecimal(Console.ReadLine());

            //height
            Console.WriteLine("Package height?");
            decimal packHeight = Convert.ToDecimal(Console.ReadLine());

            //length
            Console.WriteLine("Package length?");
            decimal packLength = Convert.ToDecimal(Console.ReadLine());

            //total
            decimal packTotal = packWidth + packHeight + packLength;

            //determine whether package is too big
            if (packTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.\n");
                Main();
            }
            else
            {
                decimal packPrice = Math.Round((((packHeight * packWidth * packLength) * packWeight) / 100),2);
                Console.WriteLine("The quote for your package is:\n" + "$" + Convert.ToString(packPrice));
                Console.WriteLine("Thank you!\n");
                Main();
            }
        }
    }
}
