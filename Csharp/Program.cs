using System;

namespace Harmonic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harmonic Number Program");
            double Num, harmonic = 0;
            Console.Write("Enter Number For Harmonic sereis no. :");
            Num = Convert.ToInt32(Console.ReadLine());

            for (double i = 1; i <= Num; i++)
            {
                harmonic = harmonic + (1 / i);
            }
            Console.WriteLine("Harmonic Number of Number {0} is : {1}", Num, harmonic);
        }
    }
}

