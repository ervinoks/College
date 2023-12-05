using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A209
{
	internal class Program
	{
		static Dictionary<int, string> numLengths = new Dictionary<int, string>(){ 
			{0, "zero"},  {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, 
			{5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}
		};
		static bool firstInput = true;
		static void Main(string[] args)
		{

			WordLength(NumWordLength(1));
			Console.WriteLine("\n");
			firstInput = true;
			WordLength(NumWordLength(987));
			Console.ReadKey();
		}
		static string NumWordLength(int num)
		{
			StringBuilder word = new StringBuilder();
			foreach (char digit in num.ToString())
			{
				word.Append(numLengths.ElementAt(int.Parse(digit.ToString())).Value);
			}
			string output = firstInput ? $"\"{word.ToString()}\"" : $", \"{word.ToString()}\"";  
			Console.Write(output);
			firstInput = false;
			return word.ToString();
		}
		static void WordLength(string Word)
		{
			numLengths.TryGetValue(Word.Length, out string val);
			if (Word == val)
			{
				Console.Write($".");
			}
			else
			{
				WordLength(NumWordLength(Word.Length));
			}
		}
	}
}
