using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Potion Felix_Felicis = new Potion(10, 192, 192, 192);
			Potion Polyjuice_Potion = new Potion(5, 0, 128, 0);
			Potion Mixed_Potion = new Potion(0, 0, 0, 0);
			Mixed_Potion = Felix_Felicis.Mix(Polyjuice_Potion);
			Console.Write($"Felix Felicis: \n  Volume: {Felix_Felicis.getVolume}\n  Colour: ");
			PrintColour(Felix_Felicis);
			Console.Write($"\nPolyjuice Potion: \n  Volume: {Polyjuice_Potion.getVolume}\n  Colour: "); 
			PrintColour(Polyjuice_Potion);
			Console.Write($"\n\nMixed Potion: \n  Volume: {Mixed_Potion.getVolume}\n  Colour: ");
			PrintColour(Mixed_Potion);
			Console.ReadKey();
			void PrintColour(Potion potion)
			{
				for (int i = 0; i < 3; i++)
				{
					int[] PotionColours = potion.getColour;
					Console.ForegroundColor = ConsoleColor.Black;
					ConsoleColor[] colours = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue };
					Console.BackgroundColor = colours[i];
					Console.Write(PotionColours[i]);
					Console.ResetColor();
					if (i == 0 || i == 1) Console.Write(", ");
				}
			}
		}
	}
}
