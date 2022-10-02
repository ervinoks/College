using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101
{
    internal class SelectionBasics2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int num = int.Parse(Console.ReadLine());
            if (num < 5000 && num > 1000)
            {
                Console.WriteLine("Correct!");
            }
            else if (num < 1000)
            {
                Console.WriteLine("Too small");
            }
            else //(greater than 5000)
            {
                Console.WriteLine("Too big");
            }
            Console.ReadKey();
        }
    }
}