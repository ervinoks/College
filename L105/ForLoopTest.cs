using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105
{
    internal class ForLoopTest
    {
        static void Main(string[] args)
        {
            //for (int i = 10; i != 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            
            //int i;
            //int j = 3;
            //for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
            //{
            //    //
            //}


            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine("I must always give my homework on time");
            //}

            //Console.WriteLine("Input a message:");
            //string input = Console.ReadLine();
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(input);
            //}

            Console.WriteLine("Input a message:");
            string input = Console.ReadLine();
            Console.WriteLine("Input how many times you want this to print:");
            int numTimes = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numTimes; i++)
            {
                Console.WriteLine(input);
            }

            Console.ReadKey();
        }
    }
}
