using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP1
{
	internal class Program2
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int suit, num;
			List<string> hand = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                string card = "";
                suit = r.Next(0, 4); num = r.Next(1, 14);
                switch (num)
                {
                    case 1:
                        card += "Ace";
                        break;
                    case 11:
                        card += "Jack";
                        break;
                    case 12:
                        card += "Queen";
                        break;
                    case 13:
                        card += "King";
                        break;
                    default:
                        card += num;
                        break;
                }
                switch (suit)
                {
                    case 0:
                        card += " of Spades";
                        break;
                    case 1:
                        card += " of Clubs";
                        break;
                    case 2:
                        card += " of Diamonds";
                        break;
                    case 3:
                        card += " of Hearts";
                        break;

                }
                hand.Add(card);
            }
            foreach (string card in hand) { Console.WriteLine(card); }
            Console.ReadKey();
		}
	}
}
