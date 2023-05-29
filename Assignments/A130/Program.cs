using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the text to compress: ");
            string text = Console.ReadLine();
            StringBuilder compressedText = new StringBuilder();
            char currentChar = text[0];
            int charCount = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (currentChar == text[i])
                {
                    charCount++;
                }
                else
                {
                    compressedText.Append($"{currentChar} {charCount} ");
                    currentChar = text[i];
                    charCount = 1;
                }
            }
            compressedText.Append($"{currentChar} {charCount}");
            Console.WriteLine(compressedText.ToString());
            Console.ReadKey();
        }
    }
}
