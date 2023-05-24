using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[31];
            fibonacci[0] = 0; fibonacci[1] = 1;
            for (int i = 2; i < fibonacci.Length; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            Console.WriteLine(string.Join(", ", fibonacci));
            float total = 0;
            foreach (int num in fibonacci)
            {
                total += num;
            }
            float average = total / fibonacci.Length;
            Console.WriteLine($"The mean of this section of the Fibonacci sequence is {average}");
            Console.ReadKey();
        }
    }
}
