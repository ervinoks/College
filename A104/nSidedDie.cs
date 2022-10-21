using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104
{
    internal class nSidedDie
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sides are on your die?");
            int sides = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rolls do you want?");
            int rolls = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            Console.WriteLine();
            for (int i = 0; i < rolls; i++)
            {
                Console.WriteLine(rnd.Next(1, sides + 1));
            }
            Console.ReadKey();
        }
    }
}
