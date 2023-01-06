using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A109
{
	internal class ParallelArrays
	{
		static int CheckStats(int[] scores, int choice, int totalScore)
		{
			int[] points = new int[choice];
			for (int i = 0; i < choice; i++)
			{
				if (scores[i] == 15) { points[i] = scores[i] - 6; }
				else if (scores[i] == 14) { points[i] = scores[i] - 7; }
				else { points[i] = (scores[i] - 8); }
			}
			int totalPoints = points.Sum();
			return totalPoints;
		}
		static string[] StatsRemover(string[] allStats, int choice)
		{
			Console.Write("Choose which stats to remove: ");
			Console.WriteLine(String.Join(", ", allStats));
			choice = 6 - choice;
			string[] removedStats = new string[choice];
			for (int i = 0; i < choice; i++)
			{
				removedStats[i] = Console.ReadLine().ToLower();
				removedStats[i] = char.ToUpper(removedStats[i][0]) + removedStats[i].Substring(1);
			}
			IEnumerable<string> changedStats = allStats.Except(removedStats); 
			string[] stats = changedStats.ToArray<string>();
			return stats;
		}
		static void Main(string[] args)
		{
			string[] allStats = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" }, stats;
			Console.Write("How many stats do you want to enter? You must put a minimum of 1, maximum of 6: ");
			int choice = int.Parse(Console.ReadLine());
			while ((choice < 1) || (choice > 6))
			{
				Console.Write("Invalid amount. Please enter a number between 1 and 6: ");
				choice = int.Parse(Console.ReadLine());
			}
			if (choice < 6) { stats = StatsRemover(allStats, choice); }
			else { stats = allStats; }
			int[] scores = new int[choice];

			int maxScore = choice * 9;
			Console.Write($"Input the total score you want, default is 27, max is {maxScore}: ");
			int totalScore = int.Parse(Console.ReadLine());
			while (totalScore > maxScore)
			{
				Console.Write($"Invalid total points. Please enter a number less than {maxScore}: ");
				totalScore = int.Parse(Console.ReadLine());
			}
			Console.Clear();

			for (int i = 0; i < choice; i++)
			{
				Console.Write($"Enter a score for {stats[i]}: ");
				int stat = int.Parse(Console.ReadLine());
				while ((stat < 8) || (stat > 15))
				{
					Console.Write($"Invalid score. Please enter a score for {stats[i]} between 8 and 15: ");
					stat = int.Parse(Console.ReadLine());
				}
				scores[i] = stat;
			}
			var completeStats = stats.Zip(scores, (stat, score) => new { Stat = stat, Score = score });
			int totalPoints = CheckStats(scores, choice, totalScore);
			foreach (var item in completeStats) { Console.WriteLine($"{item.Stat}: {item.Score}"); }
			Console.WriteLine($"Total score: {totalPoints}");
			if (totalPoints == totalScore) { Console.WriteLine("You have a valid score."); }
			else { Console.WriteLine($"You have an invalid score."); }
			Console.ReadKey();
		}
	}
}
