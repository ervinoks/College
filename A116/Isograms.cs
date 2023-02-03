using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A116
{
	internal class Isograms
	{
		static bool Isogram(string input)
		{
			bool isIsogram = true;
			foreach (char letter in input)
			{
				if (input.Count(x => x == letter) > 1) { isIsogram = false; }
			}
			return isIsogram;
		}
		static void Main(string[] args)
		{
			Console.Write("Input a string to check if it is an isogram: ");
			string input = Console.ReadLine();
			if (Isogram(input)) { Console.WriteLine("The string is an isogram."); }
			else { Console.WriteLine("The string is not an isogram."); }
			Console.ReadKey();
		}
	}
}
