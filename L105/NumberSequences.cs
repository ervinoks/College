using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105
{
    internal class NumberSequences
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What sequence do you want to generate? (n ? ?)");
            //var sequence = Console.ReadLine();
            //Console.WriteLine(sequence);

            int n = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());
            var op = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            switch (op)
            {
                case "*":
                case "x": //acts as an "or" in a switch case - as or doesn't work in C# 7.3, only 9.0 which isn't availible in any .NET Framework version
                    Console.WriteLine(n * num);
                    break;
                case "+":
                    Console.WriteLine(n + num);
                    break;
                case "-":
                    Console.WriteLine(n - num);
                    break;
                case "/":
                    Console.WriteLine(n / num);
                    break;
                case "%":
                    Console.WriteLine(n % num);
                    break;
                case "**":
                    Console.WriteLine(Math.Pow(n, num));
                    break;
                default:
                    throw new ArgumentException("Unexpected operator string: " + op); //provides error where the operator inputted doesn't work
            }
            Console.ReadKey();
        }
    }
}