using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L116
{
    internal class Arrays
    {
        static string[] names = { "Alpha", "Beta", "Charlie", "Delta", "Echo" };
        static void twos()
        {
            int[] two = new int[8];
            for (int i = 0; i < two.Length; i++) { two[i] = 2; }
            foreach (var twos in two) { Console.WriteLine(twos); }
        }
        static void forward()
        {
            for (int i = 0; i < names.Length; i++) { Console.WriteLine(names[i]); }
        }
        static void backward()
        {
            for (int i = names.Length - 1; i > -1; i--) { Console.WriteLine(names[i]); }
        }
        static int[] countedChars = new int[5];
        static void charCounter(char input)
        {   
            for (int i = 0; i < names.Length; i++) 
            {
                int count = 0; 
                foreach (char c in names[i])
                {
                    if (c == input)
                    {
                        count++;
                    }
                }
                countedChars[i] = count;
            }
        }
        static float mean;
        static void meanChars()
        {
            float totalCount = 0;
            for (int i = 0; i < countedChars.Length; i++) 
            {
                Console.WriteLine(countedChars[i]);
                totalCount += countedChars[i]; 
            }
            mean = totalCount / countedChars.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a) Twos:");
            twos();
            Console.WriteLine();
            Console.WriteLine("b) Forward:");
            forward();
            Console.WriteLine();
            Console.WriteLine("c) Backward:");
            backward();
            Console.WriteLine();
            Console.WriteLine("d) Character Counter:");
            Console.WriteLine("Input a character to search for in the names array: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            charCounter(input);
            Console.WriteLine();
            Console.WriteLine("e) Mean:");
            meanChars();
            Console.WriteLine($"The mean number of character {input} is {mean}");
            Console.ReadKey();
        }
    }
}
