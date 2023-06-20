using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace A131
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter integer (0-99): ");
			int input = int.Parse(Console.ReadLine());
			Console.Write("Calculate additive or multiplicative persistence? ('a' or 'm'): ");
			char persChoice = char.Parse(Console.ReadLine());
			Console.WriteLine($"The persistence of {input} is {Persistence(input, persChoice)}");
			Console.ReadKey();
		}
		static int Persistence(int Input, char Choice)
		{
			int count = 0;
			int Calc(in int input)
			{
				if (input.ToString().Length == 1) return input;
				count++;
				return Choice == 'a' ? Calc((input / 10) + (input % 10)) : Calc((input / 10) * (input % 10));
			}
			Calc(Input);
			return count;
		}
	}
}
