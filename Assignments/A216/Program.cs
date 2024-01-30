using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A216
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text;
			text = "Yesterday, we bumped into Laura. " +
				"It had to happen, but you can't deny the timing couldn't be worse. " +
				"The mission to try and win her was a complete failure last month. " +
				"By the way, she still has the diary I gave her. " +
				"Anyhow, it hasn't been fun. " +
				"I wanted to be done with it all.";
			Console.WriteLine($"{text}\n\nDecoded message: {Decode(text)}\n\n\n");
			text = "Gryffindor were practising Quidditch. " +
				"Aside from the rain it hadn't been a happy practice session. " +
				"Snape had been spying on them. " +
				"Fred and George wanted to drop a stink bomb on Snape, but Wood did not allow this. " +
				"Snape would do anything to ensure that the Slytherin team win the Quidditch cup again.";
			Console.WriteLine($"{text}\n\nDecoded message: {Decode(text)}");
			Console.ReadKey();
		}
		static List<char> Delimiters = new List<char>() { '.', '!', '?' };
		static string Decode(string encoding)
		{
			string[] words = encoding.Split(' ');
			StringBuilder decoded = new StringBuilder();
			bool firstSentence = true, foundInSentence = true;
			List<int> positionOfWordsToTake = new List<int>();
			int _len, posInFullText = 0, posInSentence = 0, puncAmount;
			
			foreach (string word in words)
			{
				if (firstSentence)
				{
					puncAmount = word.Count(char.IsPunctuation);
					_len = puncAmount == 0 ? word.Length : word.Length - puncAmount; 
					positionOfWordsToTake.Add(_len);
				}
				if (Delimiters.Contains(word.Last()))
				{
					if (firstSentence) firstSentence = false;
					posInSentence = 0;
					foundInSentence = false;
				}
				if (positionOfWordsToTake.Count == 0) break;
				if (word == words[posInFullText + positionOfWordsToTake.First() - posInSentence] && !foundInSentence)
				{
					decoded.Append(word + " ");
					positionOfWordsToTake.RemoveAt(0);
					foundInSentence = true;
				}
				posInSentence++;
				posInFullText++;
			}
			return decoded.ToString();
		}
	}
}
