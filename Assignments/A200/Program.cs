using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A200
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> words = new List<string> { "ABodE", "abc", "xYz", "xBkd" };
			Console.WriteLine($"{string.Join(", ", words)} : {string.Join(", ", AlphabetPositionCount(words))}");
			Console.ReadKey();
		}

		static List<int> AlphabetPositionCount(List<string> words)
		{
			List<int> counts = new List<int>();
			
			foreach (string word in words)
			{	
				int count = 0;
				for (int i = 0; i < word.Length; i++)
				{
					char letter = word[i];
					letter = char.ToLower(letter);
					// calc the expected position in the alphabet (0-based)
					int expectedPosition = letter - 'a';
					// check if the letter's position matches its position in the alphabet
					if (expectedPosition == i)
					{
						count++;
					}
				}
				counts.Add(count);
			}
			return counts;
		}
	}
}
