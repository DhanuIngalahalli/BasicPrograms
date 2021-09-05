using System;

namespace FlipCoin_Percentage
{
    class Program
    {
        static void Main(string[] args)
        {
            //flip the coin and calculate percentage
            Console.WriteLine("Calculate the Percentage");
            Random rand = new Random();
            int heads = 0, tails = 0, result = 0;

            for (int i = 1; i <= 5; i++)
            {
                result = rand.Next(0, 2);

                if (result == 1)

                {

                    heads++;

                }

                else

                {

                    tails++;

                }

                double coin = rand.NextDouble();
                if (coin < 0.5)
                {
                    Console.WriteLine(coin + " Tail");
                    heads += 1;
                }
                else
                {
                    Console.WriteLine(coin + " Head");
                    tails += 1;
                }
            }
            Console.WriteLine("The Ratio of Tail:Head is : ({0}:{1})", heads, tails);
            Console.WriteLine("Percentage of Tail is : {0}%", tails * 10);
            Console.WriteLine("Percentage of Head is : {0}%", heads * 10);
        }
    }
}