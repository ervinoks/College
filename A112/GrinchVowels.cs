using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A112
{
	internal class GrinchVowels
	{
		static int CountCharsInFile(string fileName, char target)
		{
			int count = 0;
			string contents = File.ReadAllText(fileName);
			foreach (char item in contents) { if (item == target) { count++; } }
			return count;
		}
		static string vowels(string fileName)
		{
			char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
			int[] counts = new int[5];
			string vowelsWithCounts = String.Empty;
			for (int i = 0; i < 5; i++)
			{
				counts[i] = CountCharsInFile(fileName, vowels[i]);
				vowelsWithCounts += $"There are {counts[i]} {vowels[i]}'s in the file\n";
			}
			vowelsWithCounts += vowellessText(File.ReadAllText(fileName));
			return vowelsWithCounts;
		}	   
		static readonly Func<string, string> vowellessText = text => text.Replace("a", string.Empty)
																		 .Replace("e", string.Empty)
																		 .Replace("i", string.Empty)		
																		 .Replace("o", string.Empty)
																		 .Replace("u", string.Empty);
		static void Main(string[] args)
		{
			string fileGrinch1 = @"A112 - Grinch1.txt", fileGrinch2 = @"A112 - Grinch2.txt",
				fileVowels = @"vowels.txt", filePath = Directory.GetCurrentDirectory(), fileChoice;
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			fileGrinch1 = filePath + fileGrinch1; fileGrinch2 = filePath + fileGrinch2; fileVowels = filePath + fileVowels;
			Console.WriteLine("Choose which file to pick, Grinch1 or Grinch2?");
			int choice = int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1:
				default:
					fileChoice = fileGrinch1;
					break;
				case 2:
					fileChoice = fileGrinch2;
					break;
			}
			string finalString = vowels(fileChoice);
			File.WriteAllText(fileVowels, finalString);
			Console.ReadKey();
		}
	}
}
