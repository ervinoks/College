using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP1
{
	internal class Program1
	{
		static void Main(string[] args)
		{
			int NumberToGuess, NumberOfGuesses, Guess;
			Console.WriteLine("Player One enter your chosen number: ");
			NumberToGuess = int.Parse(Console.ReadLine());
			while (NumberToGuess < 1 || NumberToGuess > 10)
			{
				Console.WriteLine("Not a valid choice, please enter another number: ");
				NumberToGuess = int.Parse(Console.ReadLine());
			}
			Guess = 0; NumberOfGuesses = 0;
			while (Guess != NumberToGuess && NumberOfGuesses < 5)
			{
				Console.WriteLine("Player Two have a guess: ");
				Guess = int.Parse(Console.ReadLine());
				NumberOfGuesses = NumberOfGuesses + 1;
			}
			if (Guess == NumberToGuess) { Console.WriteLine("Player Two wins"); }
			else { Console.WriteLine("Player One wins"); }
			Console.ReadKey();
		}
	}
}