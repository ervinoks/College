using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L112
{
    internal class DoItDjent
    {
        static void Guitar(int strings, string size)
        {
            Console.WriteLine("do it djent?");
            if (strings >= 18 && size == "big") Console.WriteLine("it sure does djent");
            else if (strings >= 4 && size == "normal") Console.WriteLine("well it guitars");
            else if (strings < 4 && size == "small") Console.WriteLine("it ukeleles");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("strings?");
            int numStrings = int.Parse(Console.ReadLine());
            Console.WriteLine("size?");
            string guitarSize = Console.ReadLine();
            Guitar(numStrings, guitarSize);

            Console.ReadKey();
        }
    }
}
