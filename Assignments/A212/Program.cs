using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace A212
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DisplayChristmasTree(10);
			Console.WriteLine();
			DisplayChristmasTree(25);
			Console.ReadKey();
		}
		static void DisplayChristmasTree(int height)
		{
			// generate tree sections
			int _max = 5;
			for (int i = 1; i <= height; i += 3)
			{  
				for (int j = _max - 4; j <= _max; j += 2)
				{
					string stars = new string('*', j);
					Console.WriteLine(stars.PadLeft((int)(Math.Ceiling((double)(height + j + 1) / 2))));
				}
				_max += 2;
			}
			// tree root
			string root = new string('#', 3);
			Console.WriteLine(root.PadLeft((int)Math.Ceiling((double)(height + 4) / 2)));
		}
	}
}
