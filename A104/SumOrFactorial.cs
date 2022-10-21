using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A104
{
    internal class SumOrFactorial
    {
        static int num = 0;
        static void sum()
        {
            int sumNum = 0;
            for (int i = 0; i < num; i++)
            {
                sumNum += i;
            }
            Console.WriteLine($"Sum of all numbers up to {num} = {sumNum}");
        }
        static void factorial()
        {
            int factorialNum = 1;
            for (int i = 1; i < num + 1; i++)
            {
                factorialNum *= i;
            }
            Console.WriteLine($"Factorial of {num} = {factorialNum}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum or Factorial? (f/s)");
            char choice = char.Parse(Console.ReadLine().ToLower());
            switch (choice)
            {
                case 'f':
                    factorial();
                    break;
                case 's':
                    sum();
                    break;
            }
            Console.ReadKey();
        }
    }
}
