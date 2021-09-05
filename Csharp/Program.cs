using System;

namespace Largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Largest Number in between Three Numbers Program");
            int num1, num2, num3;
            Console.Write("Enter The 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The 3st number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}