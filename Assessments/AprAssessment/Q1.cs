using System.Text;

namespace AprAssessment
{
	internal class Q1
	{
		static void Main(string[] args)
		{
			string DNA;
			Console.WriteLine($"DNA: {DNA = "TAGATGGCAGATAAATGA"} - has longest substring of {LongestDNASubstring(DNA)}");
			Console.WriteLine($"DNA: {DNA = "AAAACGAAATATAAGCCATGT"} - has longest substring of {LongestDNASubstring(DNA)}");
			Console.ReadKey();
		}
		static int LongestDNASubstring(string symbols)
		{
			List<int> indexes = new List<int>() { 0 };
			int i;
			StringBuilder DNASubstring = new StringBuilder();
			string ASub = "";
			bool checking = true;
			do
			{
				switch (i = symbols.IndexOf('A', indexes.Last()))
				{
					default:
						indexes.Add(i + 1);
						DNASubstring.Append('A');
						try
						{
							while (symbols[i++ + 1] == 'A')
							{
								DNASubstring.Append('A');
							}
						}
						catch { }
						if (DNASubstring.Length > ASub.Length) ASub = DNASubstring.ToString();
						DNASubstring.Clear();
						break;
					case -1:
						checking = false;
						break;
				}
			} while (checking);
			return ASub.Length;
		}
	}
}
