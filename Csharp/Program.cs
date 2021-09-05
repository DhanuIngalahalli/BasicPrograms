using System;

namespace Power_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the power");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2 to the power of {0} is" + Math.Pow(2, i), i);
            }
        }
    }
}