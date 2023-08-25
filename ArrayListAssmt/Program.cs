using System;
using System.Collections.Generic;

namespace ArrayListAssmt
{
    class Program
    {
        static void Main()
        {
            //variables
            string[] randString = { "Cat", "Dog", "Bird", "Snake", "Lizard" };
            int[] randInt = { 2, 1, 3, 5, 4 };
            List<string> savedStrings = new List<string>();

            //start
            Console.WriteLine("Random Pet Assignment Program\n\nStep 1:\nPlease type a number between 0 and 4 to determine your pet.");
            int petChoice = Convert.ToInt32(Console.ReadLine());

            while (savedStrings.Count < 3)
            {
                if (petChoice >= 0 && petChoice <= 4)
                {
                    Console.WriteLine("Your random pet is: " + randString[petChoice] + "\n");
                    savedStrings.Add(randString[petChoice]);
                    petChoice = 5;
                }
                else
                {
                    Console.WriteLine("The index you are trying to access doesn't exist\nPlease only type numbers from 0 to 4!\n");
                    Main();
                }

                //step 2
                Console.WriteLine("Step 2:\nPlease type another number between 0 and 4\nto determine how many of the above pet you are adopting.");
                int petNum = Convert.ToInt32(Console.ReadLine());

                if (petNum >= 0 && petNum <= 4)
                {
                    Console.WriteLine("Your random number of pet is: " + randInt[petNum] + "\n");
                    savedStrings.Add(Convert.ToString(randInt[petNum]));
                    petNum = 5;
                }
                else
                {
                    Console.WriteLine("The index you are trying to access doesn't exist\nPlease only type numbers from 0 to 4!\n");
                    petNum = Convert.ToInt32(Console.ReadLine());
                    Main();
                }

                Console.WriteLine("Congratulations. Please type 0 to see the type of pet your are taking home and 1 to see how many");
                int petSelect = Convert.ToInt32(Console.ReadLine());

                if (petSelect == 0)
                {
                    Console.WriteLine("Your pet is: " + savedStrings[petSelect]);
                }
                else if (petSelect == 1)
                {
                    Console.WriteLine("Your number of pets to adopt is " + savedStrings[petSelect]);
                }
                else
                {
                    Console.WriteLine("Please only type 0 or 1");
                    Main();
                }
            }
                
        }
    }
}
