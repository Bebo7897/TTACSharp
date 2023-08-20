using System;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" The Tech Academy \n Student Daily Report");

            //name
            Console.WriteLine(" What is your name?");
            string yourName = Console.ReadLine();
            //course
            Console.WriteLine(" What course are you on?");
            string yourCourse = Console.ReadLine();
            //page
            Console.WriteLine(" What page number?");
            string strPage = Console.ReadLine();
            int numPage = Convert.ToInt32(strPage);
            //Help
            Console.WriteLine(" Do you need help with anything? Please answer \"true\" or \"false\"");
            string strHelp = Console.ReadLine();
            bool valHelp = Convert.ToBoolean(strHelp);
            //Positive Exp
            Console.WriteLine(" Were there any positive exeperiences you'd like to share? Please give specifics.");
            string yourExp = Console.ReadLine();
            //Feedback
            Console.WriteLine(" Is there any other feedback you'd like to provide? Please be specific.");
            string strFeedback = Console.ReadLine();
            //Hours of study
            Console.WriteLine(" How many hours did you study today?");
            string strStudy = Console.ReadLine();
            int hourStudy = Convert.ToInt32(strStudy);

            Console.WriteLine(" Thank you for your answers. \n An instructor will respond to this shortly. \n Have a great day!");
            Console.ReadLine();
        }
    }
}
