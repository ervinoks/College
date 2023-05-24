using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102
{
    internal class Quiz
    {
        static void Main(string[] args)
        {
            int score = 0;
            Console.WriteLine("In the UK, what is the most popular boy name of 2022?"); //question 1
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("A: Jack");
            Console.WriteLine("B: Theo");
            Console.WriteLine("C: Muhammad");
            Console.WriteLine("D: George");
            string ans1 = Console.ReadLine().ToUpper();
            if (ans1 == "C")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine(""); //space between questions
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("What is the most sold flavour of Walker's crisps?"); //question 2
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("A: Cheese & Onion");
            Console.WriteLine("B: Ready Salted");
            Console.WriteLine("C: Salt & Vinegar");
            Console.WriteLine("D: Prawn Cocktail");
            string ans2 = Console.ReadLine().ToUpper();
            if (ans2 == "A")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine(""); //space between questions
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("How many permanent teeth does a dog have?"); //question 3
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("A: 45");
            Console.WriteLine("B: 42");
            Console.WriteLine("C: 44");
            Console.WriteLine("D: 40");
            string ans3 = Console.ReadLine().ToUpper();
            if (ans3 == "B")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                score += 1;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine(""); //space before score
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Congratulations!!!! Your score is: " + score + "!");

            Console.ReadKey();
        }
    }
}