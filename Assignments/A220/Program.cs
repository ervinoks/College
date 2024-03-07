using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A220
{
	internal class Program
	{
		static string[,] words = {{"like", "a", "the", "what", "for", "world", "whale", "one", "last" },
			{"ocean", "beauty", "tweet", "monster", "yellow", "return", "despair", "flower", "return"},
			{"romantic", "curious", "banana", "jealousy", "tactlessly", "remorseful", "follower", "elephant", "however" },
			{ "salmonella", "consequently", "irregular", "intelligence", "vegetable", "ordinary", "alternative", "watermelon", "controversial"},
			{"lackadaisical", "serendipity", "colonoscopy", "dramatically", "parsimonious", "imagination", "electricity", "diabolical", "deforestation"},
			{"extraterrestrial", "onomatopoeia", "responsibility", "revolutionary", "generalisation", "enthusiastically", "biodiversity", "veterinarian", "characteristically"},
			{"oversimplification", "individuality", "decriminalisation", "compartmentalisation", "anaesthesiologist", "industrialisation", "buckminsterfullerene", "irresponsibility", "autobiographical"}};
		static void Main(string[] args)
		{
			Console.WriteLine("Haiku:");
			Console.WriteLine("Is it a valid Haiku? " + HaikuChecker(new string[] {"16", "28", "23" }, 
				new string[] { "77" }, 
				new string[] { "19", "45" }));
			Console.WriteLine("\nHaiku:");
			Console.WriteLine("Is it a valid Haiku? " + HaikuChecker(new string[] { "16", "47" },
				new string[] { "37", "43" },
				new string[] { "19", "25" }));
			Console.WriteLine("\nRandomly Generated Haiku: ");
			HaikuGenerator();
			Console.ReadKey();
		}
		static bool HaikuChecker(params string[][] strings)
		{
			int[] totalSyllables = new int[3];
			int[] haikuSyllables = { 5, 7, 5 };
	
			for (int i = 0;  i < 3; i++) 
			{
				foreach (string str in strings[i])
				{
					int syllables = (int)char.GetNumericValue(str[0]);
					int index = (int)char.GetNumericValue(str[1]) - 1;
					totalSyllables[i] += syllables;
					Console.Write(words[syllables - 1, index] + " ");
				}
				Console.WriteLine();
			}
			return totalSyllables.SequenceEqual(haikuSyllables);
		}
		static string[][] HaikuGenerator()
		{
			List<List<string>> HaikuList = new List<List<string>>();
			int total, rand;
			Random randomSyl = new Random(), randomInd = new Random();
			List<int>[] Syllables = new List<int>[3];
			for (int i = 0; i < 3; i++)
			{
				HaikuList.Add(new List<string>());
				Syllables[i] = new List<int>();
				total = i == 1 ? 7 : 5;
				do
				{
					rand = randomSyl.Next(1, total + 1);
					total -= rand;
					Syllables[i].Add(rand);
				} while (total != 0);
				for (int j = 0; j < Syllables[i].Count(); j++)
				{
					HaikuList[i].Add(words[Syllables[i].ElementAt(j) - 1, randomInd.Next(0, 9)]);
				}


			}
			for (int i = 0; i < 3; i++)
			{
				foreach (string str in HaikuList[i])
				{
					Console.Write(str + " ");
				}
				Console.WriteLine();
			}
			string[][] Haiku = HaikuList.Select(i => i.ToArray()).ToArray();
			return Haiku;
		}
	}
}
