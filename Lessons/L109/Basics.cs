using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L109
{
    internal class Basics
    {
        static void Main(string[] args)
        {
            int x = 0;

            /*do*/ while (x > 0)
            {
                Console.Write("Enter number: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine(x);
            } //while (x > 0);

            Console.WriteLine("DONE");
            Console.ReadKey();
        }
    }
}
