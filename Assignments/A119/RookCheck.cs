using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace A119
{
	internal class RookCheck 
	{
		static readonly int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
		const int size = 8;
		static bool[,] rook = new bool[size, size], pawns = new bool[size, size];
		static void Main() 
		{
			int x = 0; int y = 0;
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			Console.WriteLine("Input the amount of pawns you'd like to place: ");
			int pawnNum = int.Parse(Console.ReadLine());
			int[,] pawnCoords = new int[2, pawnNum]; 
			Console.Clear();
			
			while (x < 1 || x > 8)
			{
				Console.Write("\rInput 1st coordinate of ♖: ");
				var UserInput = Console.ReadKey();
				if (char.IsDigit(UserInput.KeyChar)) { x = int.Parse(UserInput.KeyChar.ToString()); }
			}
			while (y < 1 || y > 8)
			{
				Console.Write("\rInput 2nd coordinate of ♖: ");
				var UserInput = Console.ReadKey();
				if (char.IsDigit(UserInput.KeyChar)) { y = int.Parse(UserInput.KeyChar.ToString()); }
			}
			int[] rookCoords = { x, y }; 
			rook[x - 1, y - 1] = true;
			
			for (int j = 0; j < pawnNum; j++)
			{
				x = 0; y = 0;
				while (x < 1 || x > 8)
				{
					Console.Write("\rInput 1st coordinate of a ♟: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { x = int.Parse(UserInput.KeyChar.ToString()); }
				}
				while (y < 1 || y > 8)
				{
					Console.Write("\rInput 2nd coordinate of a ♟: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { y = int.Parse(UserInput.KeyChar.ToString()); }
				}
				pawnCoords[0, j] = x; pawnCoords[1, j] = y;
				pawns[x - 1, y - 1] = true;
			}
			
			Console.Clear();
			Chess();
			Console.WriteLine();

			bool anyPawn = false;
			for (int c = 0; c < 2; c++) for (int n = 0; n < pawnNum; n++)
			{
					if (rookCoords[c] == pawnCoords[c, n])
					{
						Console.WriteLine($"Pawn at ({pawnCoords[0, n]}, {pawnCoords[1, n]}) can be taken.");
						anyPawn = true;
					}
			}
			if (anyPawn == false) Console.WriteLine("No pawns can be taken.");
			Console.ReadKey();
		}
		static void Chess() 
		{ 
			const string top	= " ┏━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┳━━━┓";
			const string middle = " ┣━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━╋━━━┫";
			const string bottom = " ┗━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┻━━━┛";

			Console.WriteLine($" {top}");
			for (int y = 8; y > 0; y--) 
			{
				Console.Write("{0} ", y);
				for (int x = 0; x < size; x++) 
				{
					Console.Write($"┃ {(pawns[x, y - 1] ? '♟' : rook[x, y - 1] ? '♖' : ' ')} ");
				}
				Console.WriteLine("┃ ");
				if (y != 1) { Console.WriteLine($" {middle}"); }
				else { Console.WriteLine($" {bottom}"); }
			}

			Console.Write("   ");
			for (int i = 0; i < size; i++) 
			{
				Console.Write($" {numbers[i]}  ");
			}
		}
	}
}
