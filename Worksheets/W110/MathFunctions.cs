using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W110
{
	internal class MathFunctions
	{
		static int AddTwo(int num1, int num2)
		{
			return num1 + num2;
		}
		static int Biggest(int num1, int num2)
		{
			if (num1 > num2) { return num1; }
			else if (num1 < num2) { return num2; }
			else { return 0; }
		}
		//static bool IsOdd(int num)
		//{
		//    if ((num & 1) == 1) { return true; }
		//    else { return false; }
		//}
		static readonly Func<int, bool> isOdd = num => (num & 1) == 1;
		static readonly Func<int, bool> isPrime = num =>
		{
			if (num == 1 || num == 0) return false;
			else if (num == 2) return true;

			var limit = Math.Ceiling(Math.Sqrt(num));
			for (int i = 2; i <= limit; ++i)
				if (num % i == 0)
					return false;
			return true;
		};
		static int YearsToSeconds(int years)
		{
			int seconds = years * 365 * 24 * 60 * 60;
			return seconds;
		}
		static int Factorial(int num)
		{
			if (num != 1) { return num * Factorial(num - 1); }
			else { return 1; }
		}
		static void Main(string[] args)
		{
            Console.WriteLine("Give 2 numbers to add together:"); int num, num2; num = int.Parse(Console.ReadLine()); num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {num}, and {num2}, is {AddTwo(num, num2)}.");

            Console.WriteLine("Give 2 numbers to compare:"); num = int.Parse(Console.ReadLine()); num2 = int.Parse(Console.ReadLine());
            int biggestNum = Biggest(num, num2);
            if (biggestNum == 0) Console.WriteLine("They're the same number.");
            else Console.WriteLine($"The biggest number out of {num}, and {num2}, is {biggestNum}");

            Console.WriteLine("Give a number to check if it's odd:"); num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} being odd is {isOdd(num)}.");

            Console.WriteLine("Give a number to check if it's prime:"); num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} being prime is {isPrime(num)}.");

            Console.WriteLine("How many years have you been alive for:"); num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} years is {YearsToSeconds(num)}!");

            Console.WriteLine("Give a number to find the factorial:"); num = int.Parse(Console.ReadLine());
			Console.WriteLine($"{num}! is {Factorial(num)}");
			Console.ReadKey();
		}
	}
}