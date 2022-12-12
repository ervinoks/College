using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L112
{
	internal class DisplaysSymbols
	{
		static void DisplaySymbols(char userSymbol, int across)
		{
			Console.WriteLine(String.Concat(Enumerable.Repeat(userSymbol, across)));
		}
		static void DisplayRectangle(char userSymbol, int x, int y)
        {
			for (int i = 0; i < y; i++)
            {
				DisplaySymbols(userSymbol, x);
            }
        }
		static void Main(string[] args)
        {
            Console.WriteLine("What symbol?");
            char symbol = char.Parse(Console.ReadLine());
            Console.WriteLine("How far across?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("How far down?");
            int y = int.Parse(Console.ReadLine());
            DisplayRectangle(symbol, x, y);
            Console.ReadKey();
        }   
    }
}
