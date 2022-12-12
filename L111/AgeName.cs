using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111
{
    internal class AgeName
    {
        static string name;
        static void GetName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
        }
        static void GetAge()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colour, true);
            Console.WriteLine($"Hello {name}, {age} years old.");
        }
        static string colour;
        static void GetFavouriteColour()
        {
            Console.WriteLine("What is your favourite colour?");
            colour = Console.ReadLine();
            //if (Enum.TryParse(colour, out ConsoleColor foreground))
            //{
            //    Console.ForegroundColor = foreground;
            //}
            Console.WriteLine("hi");
        }
        static void Main(string[] args)
        {
            //GetName();
            GetFavouriteColour();
            //GetAge();
            Console.ReadKey();
        }
    }
}
