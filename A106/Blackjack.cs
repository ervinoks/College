using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace A106
{
    internal class Blackjack
    {
        static void Main(string[] args)
        {
            double money = 100;
            Console.WriteLine("You have £" + String.Format("{0:0.00}", money) + " to spend.");
            Random rand = new Random();
            Console.WriteLine("You head into the casino, to play some blackjack.");
            Thread.Sleep(1000);
            Console.WriteLine("To play blackjack, you keep collecting cards until you reach 21, or just higher than the dealer to beat them. If you have an ace, it will be an 11, then turn into a 1 if you reach over 21.");
            Thread.Sleep(1000);
            double totalWinnings = 0, totalLosses = 0;
            bool gameOver = false;
            while (gameOver != true)
            {
                double bet, bet1 = -1, bet2 = -1;
                Thread.Sleep(1000);
                do
                {
                    Console.WriteLine("Bet however much you want, and bet 0 to go back home.");
                    bet = double.Parse(Console.ReadLine());
                    if (bet > money) { Console.WriteLine("You don't have enough money for this bet."); }
                } while (bet > money);
                if (bet == 0) { gameOver = true; }
                money -= bet;
                List<int> house = new List<int>
                        {
                            rand.Next(2, 12), rand.Next(2, 12)
                        };
                List<int> user = new List<int>()
                        {
                            rand.Next(2,12), rand.Next(2,12)
                        };
                int houseTotal = house[0] + house[1], userTotal = user[0] + user[1], userCount = 1, houseCount = 1, user1Total = 0, user2Total = 0, user1Count = 1, user2Count = 1;
                string houseOutput = $"Dealer's hand is {house[0]}, {house[1]}", userOutput;
                if (user[0] == 11) { userOutput = $"Your hand is an ace and {user[1]}"; Console.WriteLine(userOutput + $", totaling {userTotal}, and the house card is {house[0]}."); }
                else if (user[1] == 11) { userOutput = $"Your hand is {user[0]} and an ace"; Console.WriteLine(userOutput + $", totaling {userTotal}, and the house card is {house[0]}."); }
                else { userOutput = $"Your hand is {user[0]} and {user[1]}"; Console.WriteLine(userOutput + ", totaling {userTotal}, and the house card is {house[0]}."); }
                bool split = false, splitCheck = false, splitPossibility = false, handOver = false;
                if (money > bet * 2) { splitPossibility = true; }
                do
                {
                    if (splitPossibility == true && user[0] == user[1] && splitCheck == false) { Console.WriteLine("Do you wish to split and double your bet, hit, or stand?"); splitCheck = true; }
                    else { Console.WriteLine("Do you wish to hit or stand?"); }
                    string input = Console.ReadLine().ToLower();
                    Thread.Sleep(1000);
                    if (user[0] == 11 && user[1] == 10 || user[0] == 10 && user[1] == 11) { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet *= 1.5; handOver = true; Console.ResetColor(); }
                    if (input == "hit")
                    {
                        userCount += 1;
                        user.Add(rand.Next(2, 11));
                        userTotal += user[userCount];
                        if (user[userCount] == 11) { userOutput += ", and an ace"; }
                        else { userOutput += $", and {user[userCount]}"; }
                        Console.WriteLine($"{userOutput}, totaling {userTotal}");
                        Thread.Sleep(1000);
                        for (int i = 0; i < user.Count; i++)
                        {
                            if (user[i] == 11 && userTotal > 21)
                            {
                                userTotal -= 10;
                                Console.WriteLine("You have an ace, and your total is over 21, so it is now 1.");
                                user[i] = 1;
                                Thread.Sleep(1000);
                            }
                        }
                        if (userTotal > 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You busted, and lost your bet."); totalLosses += bet; handOver = true; Console.ResetColor(); }                    }
                    else if (input == "stand")
                    {
                        Console.Clear();
                        Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{userOutput}, totaling {userTotal}"); Console.ResetColor();
                        Thread.Sleep(1000);
                        handOver = true;
                    }
                    else if (input == "split" && splitPossibility == true)
                    {
                        split = true;
                        Console.WriteLine("You've split your hands into 2, and doubled your bet.");
                        bet1 = bet; bet2 = bet;
                        money -= bet;
                        Thread.Sleep(1000);
                        List<int> user1 = new List<int>(); List<int> user2 = new List<int>();
                        user1.Add(user[0]); user2.Add(user[1]);
                        string user1Output = $"Your first hand is {user1[0]}", user2Output = $"Your second hand is {user2[0]}";
                        bool user1handOver = false, user2handOver = false;
                        user1.Add(rand.Next(2, 11));
                        user1Total += user1[user1Count];
                        if (user1[user1Count] == 11) { user1Output += ", and an ace"; }
                        else { user1Output += $", and {user1[user1Count]}"; }
                        Console.WriteLine($"{user1Output}, totaling {user1Total}");
                        Thread.Sleep(1000);
                        do
                        {
                            Console.WriteLine("Do you wish to hit or stand?");
                            input = Console.ReadLine().ToLower();
                            if (input == "hit")
                            {
                                user1Count += 1;
                                user1.Add(rand.Next(2, 11));
                                user1Total += user1[user1Count];
                                if (user1[user1Count] == 11) { user1Output += ", and an ace"; }
                                else { user1Output += $", and {user1[user1Count]}"; }
                                Console.WriteLine($"{user1Output}, totaling {user1Total}");
                                Thread.Sleep(1000);
                                for (int i = 0; i < user1.Count; i++)
                                {
                                    if (user1[i] == 11 && user1Total > 21)
                                    {
                                        user1Total -= 10;
                                        Console.WriteLine("You have an ace, and your total is over 21, so it is now 1.");
                                        user1[i] = 1;
                                        Thread.Sleep(1000);
                                    }
                                }
                                if (user1Total > 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You busted, and lost your bet."); totalLosses += bet1; user1handOver = true; Console.ResetColor(); }
                                else if (user1Total == 21) { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet1 *= 1.5; user1handOver = true; Console.ResetColor(); }
                            }
                            else if (input == "stand")
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{user1Output}, totaling {user1Total}"); Console.ResetColor();
                                Thread.Sleep(1000);
                                user1handOver = true;
                            }
                        } while (user1handOver != true);
                        user2.Add(rand.Next(2, 11));
                        user2Total += user2[user2Count];
                        if (user2[user2Count] == 11) { user2Output += ", and an ace"; }
                        else { user2Output += $", and {user2[user2Count]}"; }
                        Console.WriteLine($"{user2Output}, totaling {user2Total}");
                        Thread.Sleep(1000);
                        do
                        {
                            Console.WriteLine("Do you wish to hit or stand?");
                            input = Console.ReadLine().ToLower();
                            if (input == "hit")
                            {
                                user2Count += 1;
                                user2.Add(rand.Next(2, 11));
                                user2Total += user2[user1Count];
                                if (user2[user2Count] == 11) { user2Output += ", and an ace"; }
                                else { user2Output += $", and {user2[user2Count]}"; }
                                Console.WriteLine($"{user2Output}, totaling {user2Total}");
                                Thread.Sleep(1000);
                                for (int i = 0; i < user2.Count; i++)
                                {
                                    if (user2[i] == 11 && user2Total > 21)
                                    {
                                        user2Total -= 10;
                                        Console.WriteLine("You have an ace, and your total is over 21, so it is now 1.");
                                        user2[i] = 1;
                                        Thread.Sleep(1000);
                                    }
                                }
                                if (user2Total > 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You busted, and lost your bet."); totalLosses += bet2; user2handOver = true; Console.ResetColor(); }
                                else if (user2Total == 21) { Console.ForegroundColor = ConsoleColor.DarkGreen; Console.WriteLine("You got blackjack, and won 1.5x your bet."); bet2 *= 1.5; user2handOver = true; Console.ResetColor(); }
                            }
                            else if (input == "stand")
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                Console.ForegroundColor = ConsoleColor.White; Console.WriteLine($"{user2Output}, totaling {user2Total}"); Console.ResetColor();
                                Thread.Sleep(1000);
                                user2handOver = true;
                            }
                        } while (user2handOver != true);
                        handOver = true;
                    }
                } while (handOver != true);
                Thread.Sleep(1500);
                while (houseTotal < 17)
                {
                    houseCount += 1;
                    house.Add(rand.Next(2, 11));
                    houseTotal += house[houseCount];
                    houseOutput += $", and {house[houseCount]}";
                }
                Console.WriteLine($"{houseOutput}, totaling {houseTotal}");
                Thread.Sleep(1000);
                if (split == true)
                {
                    if (user1Total <= 21)
                    {
                        if (houseTotal > user1Total && houseTotal <= 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You lost your first hand."); Console.ResetColor(); totalLosses += bet1; } //first hand
                        else if (houseTotal < user1Total) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You won your first hand."); money += bet1 * 2; totalWinnings += bet1 * 2; Console.ResetColor(); }
                        else if (houseTotal == user1Total) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("You tied your first hand, and got your bet back."); money += bet1; totalWinnings += bet1; Console.ResetColor(); }
                        else if (houseTotal > 21) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Dealer went bust, you win your first hand."); money += bet1 * 2; totalWinnings += bet1 * 2; Console.ResetColor(); }
                    }
                    else
                    {
                        if (houseTotal > 21) { Console.WriteLine("Dealer went bust too! Real unlucky."); }
                        else { Console.WriteLine("What a shame, maybe next game."); }
                    }
                    if (user2Total <= 21)
                    {
                        if (houseTotal > user2Total && houseTotal <= 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("You lost your second hand."); Console.ResetColor(); totalLosses += bet2; } //second hand
                        else if (houseTotal < user2Total) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You won your second hand."); money += bet2 * 2; totalWinnings += bet2 * 2; Console.ResetColor(); }
                        else if (houseTotal == user2Total) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("You tied your second hand, and got your bet back."); money += bet2; totalWinnings += bet2; Console.ResetColor(); }
                        else if (houseTotal > 21) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Dealer went bust, you win your second hand."); money += bet2 * 2; totalWinnings += bet2 * 2; Console.ResetColor(); }
                    }
                    else
                    {
                        if (houseTotal > 21) { Console.WriteLine("Dealer went bust too! Real unlucky."); }
                        else { Console.WriteLine("What a shame, maybe next game."); }
                    }
                }
                else
                {
                    if (userTotal <= 21)
                    {
                        if (houseTotal > userTotal && houseTotal <= 21) { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("The dealer won, and you lost your bet."); Console.ResetColor(); totalLosses += bet; }
                        else if (houseTotal < userTotal) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("You won your bet of £" + String.Format("{0:0.00}", bet) + "!"); money += bet * 2; totalWinnings += bet * 2; Console.ResetColor(); }
                        else if (houseTotal == userTotal) { Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("You tied, and got your bet back."); money += bet; totalWinnings += bet; Console.ResetColor(); }
                        else if (houseTotal > 21) { Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Dealer went bust, you win your hand."); money += bet * 2; totalWinnings += bet * 2; Console.ResetColor(); }
                    }
                    else
                    {
                        if (houseTotal > 21) { Console.WriteLine("Dealer went bust too! Real unlucky."); }
                        else { Console.WriteLine("What a shame, maybe next game."); }
                    }
                }
                Thread.Sleep(5000);
                Console.Clear();
                Console.WriteLine("Your total winnings are +£" + String.Format("{0:0.00}", totalWinnings) + ", and your total losses are -£" + String.Format("{0:0.00}", totalLosses) + ".");
                Thread.Sleep(1000);
                Console.WriteLine("You have £" + String.Format("{0:0.00}", money) + " left.");
                Thread.Sleep(1000);
                Console.WriteLine("Bet again, or bet 0 to stop.");
            }
        }
    }
}