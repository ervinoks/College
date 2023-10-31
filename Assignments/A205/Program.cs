using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A205
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(IsHappy(86) + "\n");
			Console.WriteLine(IsHappy(55));
			Console.ReadKey();
		}
		static int[] UnhappyNums = { 4, 16, 20, 37, 42, 58, 89 };
		static bool IsHappy(int n)
		{
			int sum = 0;
			foreach (var digit in n.ToString())
			{
				Console.Write($"{digit}² + ");
				sum += (int)Math.Pow(int.Parse(digit.ToString()), 2);
			}
			Console.CursorLeft -= 3;
			Console.WriteLine($" = {sum}");
			if (UnhappyNums.Contains(sum))
				return false;
			else if (sum == 1)
				return true;
			else
				return IsHappy(sum);
		}
	}
}
