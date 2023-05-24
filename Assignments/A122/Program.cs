using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A122
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Input the amount of sides on your dice: ");
			Dice mydice = new Dice(int.Parse(Console.ReadLine()));
			Console.Write("Do you want to use a shield? (Y/N): ");
			char ans = Char.ToUpper(Console.ReadKey().KeyChar);
			bool choice = false; if (ans == 'y') { choice = true; }
			Console.WriteLine();
			HealingWarrior hero = new HealingWarrior("Sub-Zero", choice);
			MageWarrior enemy = new MageWarrior("Scorpion", 30, 13, false);
			#region Intro
			Console.Write($"You, ");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write($"{hero.GetName()} ");
			Console.ResetColor();
			Console.Write($"has ");
			Console.ForegroundColor = ConsoleColor.Red;
			drawHealthBar(hero.GetHealth(), hero.GetMaxHealth());
			Console.ResetColor();
			Console.Write($"\nAnd ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write($"{enemy.GetName()} ");
			Console.ResetColor();
			Console.Write($"has ");
			Console.ForegroundColor = ConsoleColor.Red;
			drawHealthBar(enemy.GetHealth(), enemy.GetMaxHealth());
			Console.ResetColor();
			Console.WriteLine("\nThe fight begins!");
			#endregion
			while (hero.IsAlive() && enemy.IsAlive())
			{
				hero.Attack(enemy, mydice.Roll());
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.Write($"{enemy.GetName()}");
				Console.ForegroundColor = ConsoleColor.Red;
				drawHealthBar(enemy.GetHealth(), enemy.GetMaxHealth());
				Console.ResetColor(); Console.WriteLine(); Thread.Sleep(1000);
				if (!enemy.IsAlive()) { break; }
				enemy.Attack(hero, mydice.Roll());
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write($"{hero.GetName()}");
				Console.ForegroundColor = ConsoleColor.Red;
				drawHealthBar(hero.GetHealth(), hero.GetMaxHealth());
				Console.ResetColor(); Console.WriteLine();
				if (!hero.IsAlive()) { break; }
				if (!hero.getHaveHealed() && hero.IsAlive() && enemy.IsAlive())
				{
					Console.Write("Would you like to use your healing? (Y/N): ");
					ans = Char.ToUpper(Console.ReadKey().KeyChar);
					if (ans == 'Y') { hero.heal(); }
					Console.SetCursorPosition(hero.GetName().Length, Console.CursorTop - 1);
					Console.ForegroundColor = ConsoleColor.Red;
					drawHealthBar(hero.GetHealth(), hero.GetMaxHealth());
					Console.ResetColor(); Console.WriteLine(); Console.WriteLine();
				}
				Console.WriteLine(); Thread.Sleep(1000);
			}
			Console.WriteLine("The fight is over!");
			string winner = hero.GetHealth() > 0 ? $"{hero.GetName()}" : $"{enemy.GetName()}";
			Console.WriteLine($"The winner is: {winner}!");
			Console.ReadKey();
		}
		private static void drawHealthBar(int progress, int total)
		{
			float onechunk = 20.0f / total;

			//draw filled part
			int beginning = Console.CursorLeft;
			int position = Console.CursorLeft + 1;
			for (int i = 0; i < onechunk * progress; i++)
			{
				Console.CursorLeft = position++;
				Console.Write("▓");
			}

			//draw unfilled part
			for (int i = position; i <= 20 + beginning; i++)
			{
				Console.CursorLeft = position++;
				Console.Write("▒");
			}

			//draw totals
			Console.CursorLeft = beginning + 23;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write($"{progress.ToString()}/{total.ToString()}");
		}
	}
}
