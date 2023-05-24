using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A111
{
	internal class Functions
	{
		static List<char> StringToList(string input)
		{
			List<char> stringList = new List<char>();
			foreach (char item in input)
			{
				stringList.Add(item);
			}
			return stringList;
		}
		static int CountCharsInList(List<char> input, char target)
		{
			int count = 0;
			foreach (char item in input)
			{
				if (item == target)
				{
					count++;
				}
			}
			return count;
		}
		static void Main(string[] args)
		{
			Console.Write("Input a string: ");
			string input = Console.ReadLine();
			List<char> chars = StringToList(input);
			Console.WriteLine();
			//for (int i = 0; i < 5; i++)
			//{
			//	Console.Write("\nInput a character to count: ");
			//	char target = char.Parse(Console.ReadLine());
			//	int count = CountCharsInList(chars, target);
			//	Console.WriteLine($"{target}: {count}"); 
			//}	 //this is for choice of your character
			Console.WriteLine($"a: {CountCharsInList(chars, 'a')}");
			Console.WriteLine($"e: {CountCharsInList(chars, 'e')}");
			Console.WriteLine($"i: {CountCharsInList(chars, 'i')}");
			Console.WriteLine($"o: {CountCharsInList(chars, 'o')}");
			Console.WriteLine($"u: {CountCharsInList(chars, 'u')}");
			Console.ReadKey();
		}
	}
}