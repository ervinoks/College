using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A108
{
	internal class NoughtsAndCrosses
	{
		static void Main(string[] args)
		{
			int NoOfGamesInMatch, NoOfGamesPlayed, PlayerOneScore, PlayerTwoScore;
			char PlayerOneWinsGame;
			PlayerOneScore = 0; PlayerTwoScore = 0;
			Console.WriteLine("How many games?");
			NoOfGamesInMatch = int.Parse(Console.ReadLine());
            for (NoOfGamesPlayed = 1; NoOfGamesPlayed <= NoOfGamesInMatch; NoOfGamesPlayed++)
            {
                Console.WriteLine("Did Player One win the game (enter Y or N)?");
                PlayerOneWinsGame = Console.ReadKey(true).KeyChar;
                if (PlayerOneWinsGame == 'Y') { PlayerOneScore += 1; }
                else { PlayerTwoScore += 1; }
            }
            Console.WriteLine(PlayerOneScore);
            Console.WriteLine(PlayerTwoScore);
            Console.ReadKey();
        }
    }
}