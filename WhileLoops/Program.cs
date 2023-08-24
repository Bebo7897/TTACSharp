using System;

namespace WhileLoops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess my favorite color in 3 guesses!\nIs it orange, blue, red, green, yellow, purple?");
            string myColor = Console.ReadLine();
            int guesses = 2;

            while (guesses > 0 && myColor != "orange")
            {
                Console.WriteLine("That's not my favorite color... Try again!");
                guesses--;
                Console.WriteLine("Remaining guesses: " + Convert.ToString(guesses + 1));
                Console.WriteLine("What's my color?");
                myColor = Console.ReadLine();
            }
            

            if (guesses >= 0)
            {
                Console.WriteLine("You guessed it!\n");
            }

            else
            {
                Console.WriteLine("Better luck next time!\n");
            }


            Console.WriteLine("Now pick a number between 1 and 10");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Random num = new Random();
            int randNum = num.Next(1, 10);

            if (myNum == randNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                do
                {
                    Console.WriteLine("Close, try again");
                    myNum = Convert.ToInt32(Console.ReadLine());
                }
                while (myNum != randNum);
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
