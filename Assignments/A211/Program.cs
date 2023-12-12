using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A211
{
	internal class Program
	{
		static HashSet<char> oneO = new HashSet<char>
			{ 'a', 'b', 'd', 'e', 'g', 'o', 'p', 'q',
			'0', '6', '9', 'D', 'O', 'P', 'Q', 'R', '@' };
		static HashSet<char> twoO = new HashSet<char> 
			{ '%', '&', 'B', '8' };
		static void Main(string[] args)
		{
			string text;
			Console.WriteLine($"\"{text = "Bananas are great"}\" has {CheckO(text)} O's");
			Console.WriteLine($"\n\"{text = "Hagrid (my brother) is small"}\" has {CheckO(text)} O's");
			Console.WriteLine($"\"{text = "8% of 60 is 4.8"}\" has {CheckO(text)} O's");
			Console.ReadKey();
		}
		static int CheckO(string input)
		{
			bool bracketStart = false;
			int o = 0;
			foreach (char c in input)
			{
				if (c == '(')
				{
					bracketStart = true;
				}
				if (bracketStart)
				{
					if (c == ')') o++; 
				}
				bracketStart = false;
				if (oneO.Contains(c))
				{
					o++;
				}
				else if (twoO.Contains(c))
				{
					o += 2;
				}
			}
			return o;
		}
	}
}
