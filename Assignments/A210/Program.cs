using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace A210
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Directory.SetCurrentDirectory(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));

			using (StreamReader sr = new("puzzleinput.txt"))
			{
				total = 0;
				var tasks = new List<Task>();
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					tasks.Add(Task.Run(() => Read(line)));
				}
				Task.WaitAll(tasks.ToArray());
			}

			Console.WriteLine(total.ToString());
			Console.ReadKey();
		}
		static int total;
		static char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		static Dictionary<string, char> numWords = new()
		{
			{"one", '1'},
			{ "two", '2' },
			{ "three", '3' },
			{ "four", '4' },
			{ "five", '5' },
			{ "six", '6' },
			{ "seven", '7' },
			{ "eight", '8' },
			{ "nine", '9' }
		};
		static object lockObject = new object();
		static void Read(string line)
		{
			int num1Pos = line.IndexOfAny(nums),
				num2Pos = line.LastIndexOfAny(nums),
				word1Pos = line.Length, word2Pos = -1, _word1Pos, _word2Pos;
			char num1 = default, num2 = default, word1Num, word2Num;
			foreach (string word in numWords.Keys)
			{
				_word1Pos = line.IndexOf(word);
				_word2Pos = line.LastIndexOf(word);
				if (_word1Pos > -1)
				{
					if (word1Pos > _word1Pos)
					{
						word1Pos = _word1Pos;
						numWords.TryGetValue(word, out word1Num);
						if (num1Pos > word1Pos) num1 = word1Num;
						else num1 = line[num1Pos];
					}
				}
				if (_word2Pos > -1)
				{
					if (word2Pos < _word2Pos) 
					{
						word2Pos = _word2Pos;
						numWords.TryGetValue(word, out word2Num);
						if (num2Pos < word2Pos) num2 = word2Num;
						else num2 = line[num2Pos];
					}
				}
			}
			if (!char.IsDigit(num1)) num1 = line[num1Pos];
			if (!char.IsDigit(num2)) num2 = line[num2Pos];
			lock (lockObject)
			{
				total += int.Parse((num1.ToString() + num2.ToString()));
			}
		}
	}
}
