using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            //VARIABLES
            string[] animals = {"Rhino", "Monkey", "Panda", "Tiger"};
            string[] hybridAnimal = new string[4];
            int[] numbers = { 5, 15, 15, 10, 25, 20, 20, 5, 0 };
            int i = 0;
            int j = 1;
            List<string> goonies = new List<string> { "Chunk", "Data", "Mikey", "Mouth", "Brand"};
            List<string> lastNames = new List<string> { "Johnson", "Jones", "Smith", "Patterson", "Smith", "Johnson", "Jones"};

            //PART ONE
            Console.WriteLine("Type the name of your favorite animal.");
            string hybrid = Console.ReadLine();

            Console.WriteLine("Your hybrid animal creations are:\n");

            for (i = 0; i < animals.Length; i++)
            {
                hybridAnimal[i] = animals[i] + hybrid;
                Console.WriteLine(hybridAnimal[i] + "\n");
            }

            //PART TWO
            do
            {
                Console.WriteLine("Infinite!\n\n");
            }
            while (i <= 0) ;

            //PART THREE
            Console.WriteLine("Number Comparison Array\n\n");

            for (i = 0; i < 8; j++,i++)
            {
                if (numbers[i] < numbers[j])
                {
                    Console.WriteLine("Number is less than next number in array");
                    Console.WriteLine(numbers[i]);
                }
                else if (numbers[i] <= numbers[j])
                {
                    Console.WriteLine("Number is less than or equal to next number in array");
                    Console.WriteLine(numbers[i]);
                }
                else
                {
                    Console.WriteLine("Number is greater than next number in array");
                    Console.WriteLine(numbers[i]);
                }
            }

            //PART FOUR
            Console.WriteLine("\nType the name of your favorite Goonie (Mikey, Brand, Chunk, Mouth, Data)\n");
            string favGoonie = Console.ReadLine();

            for (i = 0; i < goonies.Count; i++)
            {
                if (goonies[i] == favGoonie)
                {
                    Console.WriteLine("Your favorite Goonie is at index: " + i);
                    break;
                }
                else if (goonies[i] != favGoonie)
                {
                    Console.WriteLine("The name you entered is not at index" + i);
                }
            }

            //PART FIVE
            Console.WriteLine("\nType a common last name (ex. Johnson, Smith, Jones)\n");
            string commonLast = Console.ReadLine();

            for (i = 0; i < lastNames.Count; i++)
            {
                if (lastNames[i] == commonLast)
                {
                    Console.WriteLine("The last name you entered can be found at index: " + i);
                }
                else if (lastNames[i] != commonLast)
                {
                    Console.WriteLine("The name you entered is not at index: " + i);
                }
            }

            //PART SIX

            int johnson = 0;
            int jones = 0;
            int patterson = 0;
            int smith = 0;

            foreach (string lastName in lastNames)
            {
                if (lastName == "Johnson")
                {
                    johnson++;
                }
                else if (lastName == "Jones")
                {
                    jones++;
                }
                else if (lastName == "Patterson")
                {
                    patterson++;
                }
                else
                {
                    smith++;
                }
            }

            Console.WriteLine("\nThe last name Johnson appears " + johnson + " times in the list!");
            Console.WriteLine("\nThe last name Jones appears " + jones + " times in the list!");
            Console.WriteLine("\nThe last name Patterson appears " + patterson + " times in the list!");
            Console.WriteLine("\nThe last name Smith appears " + smith + " times in the list!");
        }
    }
}
