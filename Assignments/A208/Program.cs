using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A208
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string student, dish;
			Console.WriteLine($"Can {student = "cho chang"} bring { dish = "chocolate pudding"}? {feast(student, dish)}");
			Console.WriteLine($"Can {student = "ron weasley"} bring {dish = "raspberry trifle"}? {feast(student, dish)}");
			Console.ReadKey();
		}
		static bool feast(string student, string dish)
		{
			if (student[0] == dish[0])
			{
				if (student[student.Length - 1] == dish[dish.Length - 1])
				{
					return true;
				}
			}
			return false;
		}
	}
}
