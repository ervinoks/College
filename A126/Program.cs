using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A126
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number for double factorial: ");
			int input = int.Parse(Console.ReadLine());
			int iterativeAns = Iterative(input);
			Console.WriteLine($"Iterative: \n{WorkingOut} = {iterativeAns}");
			WorkingOut = null;
			int recursiveAns = Recursive(input);
			Console.WriteLine($"Recursive: \n{WorkingOut} = {Recursive(input)}");
			Console.ReadKey();
		}
		static string WorkingOut;
		static int Iterative(int input)
		{
			int result = 1;
			for (int i = input; i > 0; i -= 2)
			{
				result *= i;
				WorkingOut += String.IsNullOrEmpty(WorkingOut) ? i.ToString() : $" × {i}";
			}
			if(WorkingOut[WorkingOut.Length - 1] != '1') { WorkingOut += " × 1"; }
			return result;
		}
		static int Recursive(int input)
		{
			if (input == 1 || input == 0)
			{
				WorkingOut += " × 1";
				return 1;
			}
			else
			{
				WorkingOut += String.IsNullOrEmpty(WorkingOut) ? input.ToString() : $" × {input}";
				return (input * Recursive(input - 2));
			}
		}
	}
}
