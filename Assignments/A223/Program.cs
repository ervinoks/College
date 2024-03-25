using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A223
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Program 1: GetMiddle
			Console.WriteLine(getMiddle("Voldemort"));
			Console.WriteLine(getMiddle("Fred"));
			Console.WriteLine();
			// Program 2: Consonant Values
			string[] houses = { "gryffindor", "ravenclaw", "slytherin", "hufflepuff" };
			List<(string house, int value)> consSubstringValues = new List<(string, int)>();
			int value;
			foreach (string house in houses)
			{
				value = highestValueConsonantSubstring(house);
				Console.WriteLine($"{house}'s highest consonant substring: {value}");
				consSubstringValues.Add((house, value));
			}
			(string house, int maxValue) maxHouse = consSubstringValues.Max();
			Console.WriteLine($"\nThe house with highest consonant substring: ({maxHouse.house}: {maxHouse.maxValue})");
			Console.ReadKey();
		}
		static string getMiddle(in string input) => input.Length % 2 == 0 ?
			input.Substring((input.Length / 2) - 1, 2) : input[(input.Length - 1) / 2].ToString();
		static string vowels = "aeiou";
		static List<string> listOfConsonantSubstring(string input)
		{
			List<int> vowelIndexes =
			[
				-1,
				.. input.Select((c, index) => new { c, index })
						.Where((C) => vowels.Contains(C.c)).Select(C => C.index),
			];
			List<string> cons = new List<string>();
			for (int i = 0; i < vowelIndexes.Count; i++)
			{
				try { cons.Add(input[(vowelIndexes[i] + 1)..(vowelIndexes[i + 1])]); }
				catch { cons.Add(input[(vowelIndexes[i] + 1)..input.Length]); }
			}
			return cons;
		}
		static int highestValueConsonantSubstring(string input)
		{
			List<string> cons = listOfConsonantSubstring(input);
			List<int> consCounts = new List<int>();
			int count;
			foreach (string consSubstring in cons)
			{
				count = 0;
				foreach (char c in consSubstring)
				{
					count += c - 96;
				}
				consCounts.Add(count);
			}
			return consCounts.Max();
		}
	}
}
