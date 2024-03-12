using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A221
{
	//public static class ConsoleColor //allow for ANSI escape sequences on Windows if needed
	//{
	//	private const int STD_OUTPUT_HANDLE = -11;
	//	private const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 0x0004;

	//	[DllImport("kernel32.dll", SetLastError = true)]
	//	private static extern IntPtr GetStdHandle(int nStdHandle);

	//	[DllImport("kernel32.dll", SetLastError = true)]
	//	private static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

	//	[DllImport("kernel32.dll", SetLastError = true)]
	//	private static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

	//	public static void Initialize()
	//	{
	//		if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
	//		{
	//			EnableAnsiEscapeSequencesOnWindows();
	//		}
	//	}

	//	private static void EnableAnsiEscapeSequencesOnWindows()
	//	{
	//		IntPtr handle = GetStdHandle(STD_OUTPUT_HANDLE);
	//		if (handle == IntPtr.Zero)
	//		{
	//			throw new Exception("Cannot get standard output handle");
	//		}

	//		if (!GetConsoleMode(handle, out uint mode))
	//		{
	//			throw new Exception("Cannot get console mode");
	//		}

	//		mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
	//		if (!SetConsoleMode(handle, mode))
	//		{
	//			throw new Exception("Cannot set console mode");
	//		}
	//	}
	//}
	internal class Program
	{
		static void Main(string[] args)
		{
			//ConsoleColor.Initialize();
			Potion Felix_Felicis = new Potion(10, 192, 192, 192);
			Potion Polyjuice_Potion = new Potion(5, 0, 128, 0);
			Potion Mixed_Potion = new Potion(0, 0, 0, 0);
			Mixed_Potion = Felix_Felicis.Mix(Polyjuice_Potion);
			Console.Write($"Felix Felicis: \n  Volume: {Felix_Felicis.Volume}\n  Colour: ");
			PrintColour(Felix_Felicis);
			Console.Write($"\nPolyjuice Potion: \n  Volume: {Polyjuice_Potion.Volume}\n  Colour: "); 
			PrintColour(Polyjuice_Potion);
			Console.Write($"\n\nMixed Potion: \n  Volume: {Mixed_Potion.Volume}\n  Colour: ");
			PrintColour(Mixed_Potion);
			Console.WriteLine();
			Console.ReadKey();
			void PrintColour(Potion potion)
			{
				byte[] PotionColours = potion.Colour;
				System.ConsoleColor[] colours = { System.ConsoleColor.Red, System.ConsoleColor.Green, System.ConsoleColor.Blue };
				string AnsiColour = $"\x1b[48;2;{PotionColours[0]};{PotionColours[1]};{PotionColours[2]}m";
				const string AnsiReset = "\x1b[0m";
				for (int i = 0; i < 3; i++)
				{
					Console.ForegroundColor = System.ConsoleColor.Gray;
					Console.Write($"\x1b[48;2;{string.Concat(Enumerable.Repeat("0;", i))}{PotionColours[i]}{string.Concat(Enumerable.Repeat(";0", 2 - i))}m{PotionColours[i]}{AnsiReset}");
					Console.ResetColor();
					if (i == 0 || i == 1) Console.Write(", ");
				}
				Console.Write(": ");
				Console.WriteLine(AnsiColour + "  " + AnsiReset);
			}
		}
	}
}
