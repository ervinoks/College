using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A113
{
	internal class LeapYearCalc
	{
		static bool LeapYear(int year)
		{
			if (year % 4 == 0)
			{
				if (year % 100 == 0)
				{
					if (year % 400 == 0) { return true; }
					else { return false; }
				}
				else { return true; }
			}
			else { return false; }
		}
		static void Main(string[] args)
		{
			Console.Write("Enter a year: ");
			bool isLeap = LeapYear(int.Parse(Console.ReadLine()));
			if (isLeap == true) { Console.WriteLine("This is a leap year"); }
			else { Console.WriteLine("This is NOT a leap year"); }
			Console.ReadKey();
		}
	}
}
