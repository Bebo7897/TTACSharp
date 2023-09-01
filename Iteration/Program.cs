using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main()
        {
            //VARIABLES
            string[] animals = { "Rhino", "Monkey", "Panda", "Tiger" };
            string[] hybridAnimal = new string[4];
            int[] numbers = { 5, 15, 15, 10, 25, 20, 20, 5, 0 };
            int i = 0;
            int j = 1;
            List<string> goonies = new List<string> { "Chunk", "Data", "Mikey", "Mouth", "Brand" };
            List<string> lastNames = new List<string> { "Johnson", "Jones", "Smith", "Patterson", "Smith", "Johnson", "Jones" };

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
            while (i <= 0);

            //PART THREE
            Console.WriteLine("Number Comparison Array\n\n");

            for (i = 0; i < 8; j++, i++)
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
            bool goonieFound = false;

            for (i = 0; i < goonies.Count; i++)
            {
                if (goonieFound == false)
                {
                    if (goonies[i] == favGoonie)
                    {
                        Console.WriteLine("Your favorite Goonie, " + favGoonie + ", was found in the array at index " + i);
                        break;
                    }

                    if (i == goonies.Count - 1)
                    {
                        Console.WriteLine("Your favorite Goonie was not found in the array!");
                    }
                }
            }


            //PART FIVE
            Console.WriteLine("\nType a common last name (ex. Johnson, Smith, Jones)\n");
            string commonLast = Console.ReadLine();
            List<int> indices = new List<int>();
            bool nameFound = false;

            for (i = 0; i < lastNames.Count; i++)
            {
                if (lastNames[i] == commonLast)
                {
                    nameFound = true;
                    indices.Add(i);
                }
            }

            if (nameFound == true)
            {
                foreach (int index in indices)
                {
                    Console.WriteLine(commonLast + " is found at index " + index + " in the list!\n");
                } 
            }
            else
            {
                Console.WriteLine("The last name you typed is not in the list\n");
            }

            //PART SIX

            List<string> repNames = new List<string>();

            foreach (string lastName in lastNames)
            {
                if (repNames.Contains(lastName))
                {
                    Console.WriteLine(lastName + " has already been seen");

                }
                else
                {
                    repNames.Add(lastName);
                    Console.WriteLine(lastName + " has not been seen yet!");
                }

            }
        }
     
    }
}
