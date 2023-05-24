using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A107
{
    internal class SmallestElement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want your array length to be?"); int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length + 1];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int minNumber = numbers[0];
            for (int j = 1; j < length; j++)
            {
                if (numbers[j] < minNumber)                                                             
                {
                    minNumber = numbers[j];
                }
            }
            Console.WriteLine($"The smallest number in the array is {minNumber}");
            Console.ReadKey();
        }
    }
}
