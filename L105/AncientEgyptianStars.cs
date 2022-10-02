using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105
{
    internal class AncientEgyptianStars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How tall do you want your pyramid?");
            int height = int.Parse(Console.ReadLine());
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", height - i)) + String.Concat(Enumerable.Repeat("*", i)));
            }
            Console.ReadKey();
        }
    }
}
