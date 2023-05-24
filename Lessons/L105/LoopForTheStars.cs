using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105
{
    internal class LoopForTheStars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many stars do you want to see in a row?");
            int stars = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rows?");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 0; i < rows; i++) //for loop for the amount of asked rows
            {
                /*          // ALTERNATIVE METHOD USING NESTED LOOP
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine()
                */
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", stars))); //concatenates the asked amount of stars
            }
            Console.ReadKey();
        }
    }
}
