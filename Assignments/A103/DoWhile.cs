using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103
{
    internal class DoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int input = int.Parse(Console.ReadLine());
            int num = -1;
            do
            {
                Console.WriteLine(num += 1);
            } while (num != input);
            Console.ReadKey();
        }
    }
}
