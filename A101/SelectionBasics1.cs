using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101
{
    internal class SelectionBasics1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number:");
            int second = int.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine("first");
            }
            else if (second > first)
            {
                Console.WriteLine("second");
            }
            else
            {
                Console.WriteLine("They're equal.");
            }
            Console.ReadKey();
        }
    }
}