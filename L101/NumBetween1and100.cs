using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101
{
    internal class NumBetween1and100
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                Console.Write("Your number is between 1 and 100.");
            }
            else if (num < 1)
            {
                Console.Write("Your number is too small.");
            }
            else if (num > 100)
            {
                Console.Write("Your number is too big.");
            }
            Console.ReadKey();

        }
    }
}