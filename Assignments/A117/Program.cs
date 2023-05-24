using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A117
{
    internal class Program
    {
        static string binaryFlip(byte binary, int position)
        {
            string binaryString = Convert.ToString(binary, 2); char[] binaryList = new char[binaryString.Length];
            int i = 0; foreach(char bit in binaryString) { binaryList[i++] = bit; }
            for (i = position - 1; i < binaryList.Length; i++)
            {
                if (binaryList[i] == '0') { binaryList[i] = '1'; }
                else { binaryList[i] = '0'; }
            }
            byte result = Convert.ToByte(String.Join("", binaryList), 2);
            return Convert.ToString(result, 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Input a binary value up to 8 digits: ");
            byte binary = Convert.ToByte(Console.ReadLine(), 2);
            Console.Write("Input a position to flip: ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine($"The result is: {binaryFlip(binary, position)}");
            Console.ReadKey();
        }
    }
}
