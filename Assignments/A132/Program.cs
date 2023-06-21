using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A132
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter an ISBN number:");
			string isbn = Console.ReadLine();
			if (IsValid(isbn)) Console.WriteLine("The ISBN number is valid.");
			else Console.WriteLine("Invalid ISBN number.");
			Console.ReadKey();
		}
		static bool IsValid(string isbn)
		{
			int sum = 0;
			for (int i = 0; i < isbn.Length - 1; i++)
			{
				char c = isbn[i];
				if (char.IsDigit(c))
				{
					int d = int.Parse(c.ToString());
					sum += i % 2 == 0 ? d : d * 3;
				}
				else return false;
			}
			int checkDigit = (10 - sum % 10) % 10;
			char lastChar = isbn[isbn.Length - 1];
			if (!char.IsDigit(lastChar)) 
				return false;
			return checkDigit == int.Parse(lastChar.ToString());
		}
	}
}

