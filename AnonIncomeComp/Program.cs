using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program");
        //Person 1
        Console.WriteLine("Person 1");
        Console.WriteLine("Hourly Rate?");
        string strInc1 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hoursWeek1 = Console.ReadLine();

        //Person 2
        Console.WriteLine("Person 2");
        Console.WriteLine("Hourly Rate?");
        string strInc2 = Console.ReadLine();
        Console.WriteLine("Hours worked per week?");
        string hoursWeek2 = Console.ReadLine();

        decimal incomeOne = Convert.ToDecimal(strInc1);
        decimal incomeTwo = Convert.ToDecimal(strInc2);
        decimal hoursOne = Convert.ToDecimal(hoursWeek1);
        decimal hoursTwo = Convert.ToDecimal(hoursWeek2);
        decimal annualOne = (incomeOne * hoursOne) * 52;
        decimal annualTwo = (incomeTwo * hoursTwo) * 52;

        //Annual 1
        Console.WriteLine("Annual Salary of Person 1");
        Console.WriteLine(Convert.ToString(annualOne));
        //Annual 2
        Console.WriteLine("Annual Salary of Person 2");
        Console.WriteLine(Convert.ToString(annualTwo));

        //Comparison
        Console.WriteLine("Does Person 1 make more money than Person 2?");
        Console.WriteLine(Convert.ToString(annualOne > annualTwo));
    }
}
