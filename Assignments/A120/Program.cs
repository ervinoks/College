using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A120
{
	internal class Program
	{
		static int[] SumsInit(ref int[,] randoms, string decider)
		{
			int[] sums = new int[5]; int x, y;
			switch (decider)
			{
				case "rows":
					for (y = 0; y < 5; y++) { for (x = 0; x < 5; x++) { sums[x] += randoms[x, y]; } }
					break;
				case "columns":
					for (x = 0; x < 5; x++) { for (y = 0; y < 5; y++) { sums[y] += randoms[x, y]; } }
					break;
			}
			return sums;
		}
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Random rnd = new Random();
			int[,] randoms = new int[5, 5]; // table of random numbers
			
			for (int x = 0; x < 5; x++) { for (int y = 0; y < 5; y++)
				{
					randoms[x, y] = rnd.Next(10, 100); // initialises the "random table"
				} }
			int[] sumsY = SumsInit(ref randoms, "rows"), sumsX = SumsInit(ref randoms, "columns"); // sums: Y = rows, X = columns
			const string top =    "┏━━┳━━┳━━┳━━┳━━┓";
			const string middle = "┣━━╋━━╋━━╋━━╋━━┫";
			const string bottom = "┗━━┻━━┻━━┻━━┻━━┛";
			Console.WriteLine(top);
			for (int y = 0; y < 5; y++) // iterates through each row
			{
				for (int x = 0; x < 5; x++) // iterates through each column
				{
					Console.ResetColor();
					Console.Write("┃");
					if (sumsX[x] == sumsX.Max()) // checks if it's the highest sum COLUMN
					{
						Console.ForegroundColor = ConsoleColor.Cyan;
					}
					if (sumsY[y] == sumsY.Max()) // checks if it's the highest sum ROW
					{
						Console.ForegroundColor = ConsoleColor.Red;
					}
					if (sumsY[y] == sumsY.Max() && sumsX[x] == sumsX.Max()) // check the intersection
					{
						Console.ForegroundColor = ConsoleColor.Yellow;
					}
					Console.Write($"{randoms[x, y]}"); // inputs each random value
				}
				Console.Write($" {sumsY[y]}"); // inputs the sum of the row, at the end (and in red still if highest sum)
				Console.CursorLeft -= (sumsY[y].ToString().Length + 1); // goes back to the space before the sum
				Console.ResetColor();
				Console.Write("┃\n"); // ^^ to then put a divider in the regular grey colour
				if (y != 4) { Console.WriteLine($"{middle}"); } // fancy shmancy dividers
				else { Console.WriteLine(bottom); }
			}
			Console.ReadKey();
		}
	}
}
