using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class TimesTables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a number between 1 and 12");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " here is the Times Tables for " + num);
            for (int i = 1; i <= 12; i++) //a for loop, which goes from 1 till 12, to output each multiplication
            {
                Console.WriteLine(i + " × " + num + " = " + (i * num));
            }
            Console.ReadKey();
        }
    }
}
