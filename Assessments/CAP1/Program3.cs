using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP1
{
	internal class Program3
    {
        static (int Amount, char Choice) CharCounter(string str)
        {
            Console.Write("Input a character to count: ");
            char choice = Console.ReadKey(false).KeyChar;
            int count = 0;
            foreach (char c in str) { if (c == choice) { count++; } }
            return (count, choice);
        }
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string choice = Console.ReadLine();
            var (charAmount, charChoice) = CharCounter(choice);
            Console.WriteLine($"\nNumber of '{charChoice}'s in {choice} is {charAmount}");
            Console.ReadKey();
        }
    }
}