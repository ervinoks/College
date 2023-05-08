using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A127
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("'stressed' reversed is: ");
			ReverseString("stressed");
			Console.WriteLine("\n\n");
			Console.Write("Capital letter is: ");
			CapitalLetter("leviOsa");
			Console.Write("\n\nEven numbers from 1 => 10: ");
			EvenAndOdd(10, true);
			Console.CursorLeft -= 2; Console.Write(" \n");
			Console.Write("\n\nOdd numbers from 1 => 10: ");
			EvenAndOdd(10, false);
			Console.CursorLeft -= 2; Console.Write(" \n");
			Console.ReadKey();
		}
		#region Reverse String
		static void ReverseString(string input)
		{
			if (input.Length == 1) { Console.Write(input); return; }
			else { ReverseString(input.Substring(1)); }
			Console.Write(input[0]);
		}
		#endregion
		#region Capital Letter
		static void CapitalLetter(string input)
		{
			if (char.IsUpper(input[0])) { Console.WriteLine(input[0]); }
			else { CapitalLetter(input.Substring(1)); }
		}
		#endregion
		#region Even and Odd
		static bool end;
		static void EvenAndOdd(int ceiling, bool IsEven)
		{
			if (ceiling <= 1) { end = true; return; }
			if (IsEven)
			{
				if (end == true) { Console.WriteLine($"{ceiling}, "); }
				EvenAndOdd(ceiling - 2, true);
				Console.Write($"{ceiling}, ");
			}
			end = false;
			if (!IsEven)
			{
				if (end == true) { Console.Write($"{ceiling}, "); }
				ceiling--; if (ceiling % 2 == 0) { ceiling--; }
				EvenAndOdd(ceiling, false);
				Console.Write($"{ceiling}, ");
			}

		}
		#endregion
	}
}
