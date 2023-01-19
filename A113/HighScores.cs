using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace A113
{

	internal class HighScores
	{
		struct GameScore
        {
            public string name;
			public int score, day, month, year;
		}
		static void Main(string[] args)
		{
			string file = @"A113HighScores.txt", filePath = Directory.GetCurrentDirectory();
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\")); Directory.SetCurrentDirectory(filePath);
			List<GameScore> scores = new List<GameScore>();
			using (StreamReader sr = new StreamReader(file))
			{
				string record;
				while (sr.EndOfStream == false)
				{
					record = sr.ReadLine(); GameScore score;
					score.name = record.Substring(1, 3);
					score.score = int.Parse(record.Substring(6, 6));
					score.day = int.Parse(record.Substring(13, 2));
					score.month = int.Parse(record.Substring(16, 2));
					score.year = int.Parse(record.Substring(19, 4));
					scores.Add(score);
				}
			}
			Choosing(scores);
		}
		
		private static readonly Action<GameScore> DisplayRecord = record => 
		ConsoleWriter.Write($"Name: {{FC=White}}{record.name} " +
			$"{{/FC}}\r\nScore: {{FC=White}}{record.score.ToString("D6")} " +
			$"{{/FC}}\r\nDate: {{FC=White}}{record.day.ToString("D2")}/{record.month.ToString("D2")}/{record.year}");
		
		private static readonly Action<int> RecordCount = amount =>
		ConsoleWriter.WriteLine($"BoB has played {{FC=White}}{amount}{{/FC}} games.");
		
		private static readonly Action<double>  AverageScore = average =>
		ConsoleWriter.WriteLine($"In 2020, the average score was {{FC=White}}{average}{{/FC}}.");
		
		static void Choosing(List<GameScore> scores)
		{
			ConsoleWriter.WriteLine("{FC=White}Q1: {FC=DarkGray}Name of the player with the highest score" +
				"{FC=White}\r\nQ2: {/FC}Highest score on date 25/12/2019" +
				"{FC=White}\r\nQ3: {/FC}Times the user BoB has played" +
				"{FC=White}\r\nQ4: {/FC}Average score for 2020" +
				"{FC=White}\r\nQ5: {/FC}Highest score on leap day");
			do
			{
				Console.Write("Choose a question: ");
				int choice = int.Parse(Console.ReadLine());
				switch (choice)
				{
					case 1:
						DisplayRecord(scores.OrderByDescending(score => score.score).First());
						Console.ReadKey();
						Console.Clear();
						break;
					case 2:
						DisplayRecord(scores.Where(score => score.day == 25 && score.month == 12 && score.year == 2019)
							.OrderByDescending(score => score.score).First());
						Console.ReadKey();
						Console.Clear();
						break;
					case 3:
						RecordCount(scores.Where(score => score.name == "BoB").Count());
						Console.ReadKey();
						Console.Clear();
						break;
					case 4:
						AverageScore(scores.Where(score => score.year == 2020).Average(score => score.score));
						Console.ReadKey();
						Console.Clear();
						break;
					case 5:
						DisplayRecord(scores.Where(score => score.day == 29 && score.month == 2)
							.OrderByDescending(score => score.score).First());
						Console.ReadKey();
						Console.Clear();
						break;
					case 0:
						Environment.Exit(0); break;
				}
			} while (true);
		}
		static class ConsoleWriter
		{
			public static void Write(string msg)
			{
				if (string.IsNullOrEmpty(msg))
				{
					return;
				}

				var color_match = Regex.Match(msg, @"{[FB]C=[a-z]+}|{\/[FB]C}", RegexOptions.IgnoreCase);
				if (color_match.Success)
				{
					var initial_background_color = Console.BackgroundColor;
					var initial_foreground_color = Console.ForegroundColor;
					var background_color_history = new List<ConsoleColor>();
					var foreground_color_history = new List<ConsoleColor>();

					var current_index = 0;

					while (color_match.Success)
					{
						if ((color_match.Index - current_index) > 0)
						{
							Console.Write(msg.Substring(current_index, color_match.Index - current_index));
						}

						if (color_match.Value.StartsWith("{BC=", StringComparison.OrdinalIgnoreCase)) // set background color
						{
							var background_color_name = GetColorNameFromMatch(color_match);
							Console.BackgroundColor = GetParsedColorAndAddToHistory(background_color_name, background_color_history, initial_background_color);
						}
						else if (color_match.Value.Equals("{/BC}", StringComparison.OrdinalIgnoreCase)) // revert background color
						{
							Console.BackgroundColor = GetLastColorAndRemoveFromHistory(background_color_history, initial_background_color);
						}
						else if (color_match.Value.StartsWith("{FC=", StringComparison.OrdinalIgnoreCase)) // set foreground color
						{
							var foreground_color_name = GetColorNameFromMatch(color_match);
							Console.ForegroundColor = GetParsedColorAndAddToHistory(foreground_color_name, foreground_color_history, initial_foreground_color);
						}
						else if (color_match.Value.Equals("{/FC}", StringComparison.OrdinalIgnoreCase)) // revert foreground color
						{
							Console.ForegroundColor = GetLastColorAndRemoveFromHistory(foreground_color_history, initial_foreground_color);
						}

						current_index = color_match.Index + color_match.Length;
						color_match = color_match.NextMatch();
					}

					Console.Write(msg.Substring(current_index));

					Console.BackgroundColor = initial_background_color;
					Console.ForegroundColor = initial_foreground_color;
				}
				else
				{
					Console.Write(msg);
				}
			}
			public static void WriteLine(string msg)
			{
				Write(msg);
				Console.WriteLine();
			}

			private static string GetColorNameFromMatch(Match match)
			{
				return match.Value.Substring(4, match.Value.IndexOf("}") - 4);
			}

			private static ConsoleColor GetParsedColorAndAddToHistory(string colorName, List<ConsoleColor> colorHistory, ConsoleColor defaultColor)
			{
				var new_color = Enum.TryParse<ConsoleColor>(colorName, true, out var parsed_color) ? parsed_color : defaultColor;
				colorHistory.Add(new_color);

				return new_color;
			}

			private static ConsoleColor GetLastColorAndRemoveFromHistory(List<ConsoleColor> colorHistory, ConsoleColor defaultColor)
			{
				if (colorHistory.Any())
				{
					colorHistory.RemoveAt(colorHistory.Count - 1);
				}

				return colorHistory.Any() ? colorHistory.Last() : defaultColor;
			}
		}
	}
}