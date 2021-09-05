using System;

namespace quot_remnd
{
	class Program
	{
		static void Main(string[] args)
		{

			int x, y, quot, rem;
			Console.Write("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			y = Convert.ToInt32(Console.ReadLine());

			quot = x / y;
			rem = x % y;

			Console.WriteLine("Quotient is:" + quot);
			Console.WriteLine("Remainder is:" + rem);

		}
	}
}
