using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A134
{
	internal class Program
	{
		static readonly char[] key = 
			{ 'M', 'I', 'C', 'R', 'O', 'W', 'A', 'V', 'E', 'S' };
		static void Main(string[] args)
		{
			string _;
			Console.WriteLine($"{_ = "WAVE"}: {Encode(_, true)}");
			Console.WriteLine($"{_ = "I love cows"}: {Encode(_, true)}");
			Console.WriteLine($"{_ = "microwaves"}: {Encode(_, true)}");
			Console.WriteLine($"{_ = "my secret"}: {Encode(_)}");
			Console.ReadKey();
		}
		// note to reader: I am very aware this is an VERY inefficient method which is unnecessarily complex
		// I just wanted to add an extra challenge for myself by using the same functions (more or less)
		static string Encode(string input, bool? useKey = null)
		{
			char[] inputInChar = input.ToCharArray(), charsToSwap; string output = String.Empty;
			if (useKey == true) charsToSwap = key;
			else { charsToSwap = inputInChar; useKey = false; }
			for (int c = 0; c < input.Length; c++)
			{
				bool isUpper = input[c] == char.ToUpper(input[c]);
				int _index = Array.FindIndex(charsToSwap, (bool)useKey ? 0 : c, x => (inputInChar.Contains(char.ToUpper(x)) || inputInChar.Contains(char.ToLower(x))) && char.ToLower(input[c]) == char.ToLower(x) );
				if (charsToSwap.Contains(char.ToUpper(input[c])) || charsToSwap.Contains(char.ToLower(input[c])))
				{
					if (_index == 0) 
					{
						if (isUpper) output += charsToSwap[_index + 1];
						else output += char.ToLower(charsToSwap[_index + 1]);
					}
					else if (_index % 2 == 0)
					{
						try
						{
							if (isUpper) output += charsToSwap[_index + 1];
							else output += char.ToLower(charsToSwap[_index + 1]);
						}
						catch (IndexOutOfRangeException)
						{
							if (isUpper) output += charsToSwap[_index];
							else output += char.ToLower(charsToSwap[_index]);
						}
					}
					else if (_index == charsToSwap.Length - 1)
					{
						if (isUpper) output += charsToSwap[_index - 1];
						else output += char.ToLower(charsToSwap[_index - 1]);
					}
					else
					{
						if (isUpper) output += charsToSwap[_index - 1];
						else output += char.ToLower(charsToSwap[_index - 1]);
					}
				}
				else output += input[c];
				
			}
			return output;
		}
	}
}
