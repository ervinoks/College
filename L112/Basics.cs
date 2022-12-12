using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L112
{
    internal class Basics
    {
        static void myAdd(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"Result is: {result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your first number:");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Input your second number:");
            int secondNum = int.Parse(Console.ReadLine());
            myAdd(firstNum, secondNum);
            Console.ReadKey();
        }
    }
}
