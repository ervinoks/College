using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100
{
    internal class Basics
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum is: " + (num1 + num2));
            Console.WriteLine("The product is: " + num1 * num2);
            Console.WriteLine("The sum, squared, is: " + Math.Pow(num1 + num2, 2));
            Console.ReadKey();
        }
    }
}