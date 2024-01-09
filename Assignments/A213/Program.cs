using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A213
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Sticky Calculator\n");
			Console.Write("Enter operation: ");
			char operation = Console.ReadKey().KeyChar;
			Console.Write("\nEnter first value: ");
			decimal fVal = decimal.Parse(Console.ReadLine());
			Console.Write("Enter second value: ");
			decimal sVal = decimal.Parse(Console.ReadLine());
			Console.WriteLine($"\nResult: {stickyCalc(operation, fVal, sVal)}");
			Console.ReadKey();
		}
		static int stickyCalc(char operation, decimal firstVal, decimal secondVal)
		{
			if (firstVal < 0 || secondVal < 0) throw new ArgumentException("Values must be positive");
			secondVal = (int)Math.Round((decimal)secondVal);
			firstVal = int.Parse(Math.Round((decimal)firstVal).ToString() + secondVal.ToString());
			switch (operation)
			{
				case '+':
					return (int)(firstVal + secondVal);
				case '-':
					return (int)(firstVal - secondVal);
				case '*':
					return (int)(firstVal * secondVal);
				case '/':
					return (int)(firstVal / secondVal);
				default:
					throw new ArgumentException("Invalid operation");
			}
		}
	}
}
