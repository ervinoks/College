using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A106
{
    internal class RandomCardGenerator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many cards would you like?");
            int n = int.Parse(Console.ReadLine()), count = 0;
            Random rand = new Random();
            List<string> cards = new List<string>();
            for (int i = 0; i < n; i++)
            {
                int suit = rand.Next(4), card = rand.Next(1, 14);
                string cardName = null;
                switch (card)
                {
                    case 1:
                        cardName += "Ace of ";
                        count += 1;
                        break;
                    case 11:
                        cardName += "Jack of ";
                        count += 10;
                        break;
                    case 12:
                        cardName += "Queen of ";
                        count += 10;
                        break;
                    case 13:
                        cardName += "King of ";
                        count += 10;
                        break;
                    default:
                        cardName += (card + " of ");
                        count += card;
                        break;
                }
                switch (suit)
                {
                    case 0:
                        cardName += "Spades";
                        break;
                    case 1:
                        cardName += "Hearts";
                        break;
                    case 2:
                        cardName += "Clubs";
                        break;
                    case 3:
                        cardName += "Diamonds";
                        break;
                }
                cards.Add(cardName);
            }
            cards.ForEach(Console.WriteLine);
            Console.WriteLine($"Total value of cards are {count}");
            Console.ReadKey();
        }
    }
}