using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP1
{
	internal class Program4
	{
		static void Main(string[] args)
		{
			Console.Write("Input a string to compress: ");
			string str = Console.ReadLine();
			int count = 1;
			List<char> chars = new List<char>();
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if (i > 0)
				{
					if (c == chars.Last()) { count++; }
					else
					{
						chars.Add(char.Parse(count.ToString()));
						chars.Add(c);
						count = 1;
					}
				}
				else { chars.Add(c); };
				if (i == str.Length - 1) { chars.Add(char.Parse(count.ToString())); }
			}
			Console.WriteLine(string.Join(" ", chars));
			Console.ReadKey();
		}
	}
}