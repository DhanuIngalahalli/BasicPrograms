using System;

namespace Leap_Year
{
    class Program
    {
        static void Main(string[] args)
        {
            int check_year;
            Console.Write("Input an year : ");
            check_year = Convert.ToInt32(Console.ReadLine());

            if ((check_year % 400) == 0)
                Console.WriteLine("{0} is a leap year.\n", check_year);
            else if ((check_year % 100) == 0)
                Console.WriteLine("{0} is not a leap year.\n", check_year);
            else if ((check_year % 4) == 0)
                Console.WriteLine("{0} is a leap year.\n", check_year);
            else
                Console.WriteLine("{0} is not a leap year.\n", check_year);
        }
    }
}