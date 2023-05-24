using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Assessment
{
    internal class Q5
    {
        static List<int> OddNumbers(int highestOdd)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= highestOdd; i = i + 2)
            {
                numbers.Add(i);
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            Console.Write("Input the highest odd number: ");
            int input = int.Parse(Console.ReadLine());
            List<int> numbers = OddNumbers(input);
            Console.WriteLine(String.Join(", ", numbers));
            Console.ReadKey();
        }
    }
}
