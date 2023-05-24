using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WX02
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Pick a difficulty [E]asy, [M]edium or [H]ard");
                choice = Console.ReadLine().ToUpper();
                if (choice == "E" || choice == "M" || choice == "H")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again");
                }
            } while (true);
            int dif;
            if (choice == "E")
            {
                dif = 1;
            }
            else if (choice == "M")
            {
                dif = 2;
            }
            else if (choice == "H")
            {
                dif = 3;
            }
            else
            {
                throw new Exception();
            }

            Game n = new Game(dif);
            n.Play();
        }
    }
    class Game
    {
        private int width = 20;
        private int height = 15;
        Dictionary<int[], IPrintable> icons;
        List<Character> players;
        Random randInt = new Random();
        int itemsLeft;
        public Game(int difficulty)
        {
            Console.WriteLine("Enter your name");
            string playerName = Console.ReadLine();
            icons = new Dictionary<int[], IPrintable>();
            icons.Add(new int[2] { 0, 0 }, new Player(15, playerName));
            icons.Add(new int[2] { height - 1, width - 1 }, new Npc(0, 1));
            if (difficulty > 1)
            {
                icons.Add(new int[2] { 0, width - 1 }, new Npc(0, 2));
            }
            if (difficulty > 2)
            {
                icons.Add(new int[2] { height - 1, 0 }, new Npc(0, 3));
                ((Character)icons.Values.ElementAt(0)).ChangeScore(-15);
            }
            players = new List<Character>();
            foreach (Character c in icons.Values)
            {
                players.Add(c);
            }
            itemsLeft = 50 - 10 * difficulty;
            for (int i = 0; i < 50 - 10 * difficulty; i++)
            {
                int[] position = new int[2];
                position[0] = randInt.Next(1, height);
                position[1] = randInt.Next(1, width);
                while (icons.ContainsKey(position))
                {
                    position[0] = randInt.Next(1, height);
                    position[1] = randInt.Next(1, width);
                }
                icons.Add(position, new Item());
            }
            for (int i = 0; i < 2 + 2 * difficulty; i++)
            {
                int[] position = new int[2];
                position[0] = randInt.Next(1, height);
                position[1] = randInt.Next(1, width);
                while (icons.ContainsKey(position))
                {
                    position[0] = randInt.Next(1, height);
                    position[1] = randInt.Next(1, width);
                }
                icons.Add(position, new Trap(randInt.Next(1, 11)));
            }
        }
        public void Play()
        {

            PrintNewMap();
            do
            {
                int mistakes = 0;
                foreach (Character c in players)
                {

                    PrintMap(mistakes);
                    mistakes = 0;
                    if (c is Player)
                    {
                        mistakes = MakePlayerMove((Player)c);
                    }
                    else
                    {
                        MakeNPCMove((Npc)c);
                    }
                    System.Threading.Thread.Sleep(500);
                }
            } while (itemsLeft > 0);
            Console.Clear();
            EndGame();
        }
        private void PrintNewMap()
        {
            Console.Clear();
            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    Console.Write(" --");
                    Console.SetCursorPosition(Console.CursorLeft - 3, Console.CursorTop + 1);
                    Console.Write("|");
                    bool printed = false;
                    foreach (int[] key in icons.Keys)
                    {
                        if (key[0] == r && key[1] == c)
                        {
                            icons[key].Print();
                            printed = true;
                            break;
                        }
                    }
                    if (printed == false)
                    {
                        Console.Write("  ");
                    }
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                }
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                Console.Write("|");
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            }
            Console.SetCursorPosition(0, Console.CursorTop);
            for (int c = 0; c < width; c++)
            {
                Console.Write(" --");
            }

        }
        private void PrintMap(int mistakes)
        {

            for (int r = 0; r < height; r++)
            {
                for (int c = 0; c < width; c++)
                {
                    Console.SetCursorPosition(1 + 3 * c, 1 + 2 * r);
                    bool printed = false;
                    foreach (int[] key in icons.Keys)
                    {
                        if (key[0] == r && key[1] == c)
                        {
                            icons[key].Print();
                            printed = true;
                            break;
                        }
                    }
                    if (printed == false)
                    {
                        Console.Write("  ");
                    }
                }
            }
            Console.SetCursorPosition(0, Console.CursorTop + 2);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("                                                                     ");
            }
            for (int i = 0; i < mistakes; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("                                                                     ");
                }
            }
            Console.SetCursorPosition(0, Console.CursorTop - 6 - (3 * mistakes));
        }
        private int MakePlayerMove(Player p)
        {
            int mistakes = 0;
            int[] oldposition = new int[2];
            foreach (int[] key in icons.Keys)
            {
                if (icons[key] == p)
                {
                    oldposition = key;
                }
            }
            bool done = false;
            do
            {
                int newRow = oldposition[0];
                int newCol = oldposition[1];
                Console.WriteLine("Which direction? Use wasd");
                string choice = Console.ReadLine().ToLower();
                if (choice == "w")
                {
                    newRow--;
                }
                else if (choice == "a")
                {
                    newCol--;
                }
                else if (choice == "s")
                {
                    newRow++;
                }
                else if (choice == "d")
                {
                    newCol++;
                }
                else
                {
                    Console.WriteLine("Not a valid choice");
                    mistakes++;
                    continue;
                }
                if (newRow < 0 || newRow >= height || newCol < 0 || newCol >= width)
                {
                    Console.WriteLine("Cannot go out of bounds");
                    mistakes++;
                }
                else
                {
                    if (Move(p, newRow, newCol) == false)
                    {
                        Console.WriteLine("There is a character there already");
                        mistakes++;
                    }
                    else
                    {
                        done = true;
                    }

                }
            } while (done == false);
            return mistakes;
        }
        private void MakeNPCMove(Npc p)
        {
            int[] oldposition = new int[2];
            foreach (int[] key in icons.Keys)
            {
                if (icons[key] == p)
                {
                    oldposition = key;
                }
            }
            bool done = false;
            do
            {
                int newRow = oldposition[0];
                int newCol = oldposition[1];

                int choice = randInt.Next(0, 4);
                if (choice == 1)
                {
                    newRow--;
                }
                else if (choice == 2)
                {
                    newCol--;
                }
                else if (choice == 3)
                {
                    newRow++;
                }
                else if (choice == 0)
                {
                    newCol++;
                }
                else
                {
                    continue;
                }
                if (newRow < 0 || newRow >= height || newCol < 0 || newCol >= width)
                {
                }
                else
                {
                    done = Move(p, newRow, newCol);
                }
            } while (done == false);
        }
        private bool Move(Character p, int row, int col)
        {
            int[] oldposition = new int[2];
            foreach (int[] key in icons.Keys)
            {
                if (icons[key] == p)
                {
                    oldposition = key;
                }
            }
            foreach (int[] key in icons.Keys)
            {
                if (key[0] == row && key[1] == col)
                {
                    if (icons[key] is IScorable)
                    {
                        Console.Write(p.GetName() + " hit something! ");
                        p.ChangeScore(((IScorable)icons[key]).GetScore());
                        ((IScorable)icons[key]).PrintDescription();
                        icons.Remove(key);
                        itemsLeft--;
                        System.Threading.Thread.Sleep(1500);
                        icons.Remove(oldposition);
                        icons.Add(new int[] { row, col }, p);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            icons.Remove(oldposition);
            icons.Add(new int[] { row, col }, p);
            return true;
        }
        private void EndGame()
        {
            Console.WriteLine("Final scores");
            int bestScore = -1;
            Character bestPlayer = new Player(-1, "");
            foreach (Character c in players)
            {
                Console.WriteLine(c.GetName() + " scored " + c.GetScore() + " points.");
                if (c.GetScore() > bestScore)
                {
                    bestScore = c.GetScore();
                    bestPlayer = c;
                }
            }
            Console.WriteLine("The winner is " + bestPlayer.GetName());
            Console.ReadKey();
        }
    }
}
