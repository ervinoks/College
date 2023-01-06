using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L118
{
    internal class Split
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string of words separated with a space: ");
            string words = Console.ReadLine();
            List<string> splitString = new List<string>(words.Split());
            Console.WriteLine("[" + string.Join(", ", splitString) + "]");
            Console.ReadKey();
        }
    }
}