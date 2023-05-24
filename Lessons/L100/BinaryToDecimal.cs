﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How long is your binary digit?");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("Most significant digit, or least significant digit first? (MSB/LSB)");
            string significance = Console.ReadLine().ToUpper();
            List<int> digits = new List<int>(range) { }; //makes a list for where all the digits will be appended to in the for loops below (line 22 & line 32)
            if (significance == "MSB")
            {
                for (int i = 0; i < range; i++)
                {
                    digits.Add(int.Parse(Console.ReadLine()));
                }
                string binary = String.Join("", digits); //turns the list into a single string, called "binary"
                int denary = Convert.ToInt32(binary, 2); //converts the string into base 2, which is then recognised as an actual denary number
                Console.WriteLine("\nBinary: " + binary + "\nDenary: " + denary); //writes both the full binary string, and denary number, in seperate lines
            }
            else if (significance == "LSB")
            {
                for (int i = 0; i < range; i++)
                {
                    digits.Insert(0, int.Parse(Console.ReadLine()));
                }
                string binary = String.Join("", digits);
                int denary = Convert.ToInt32(binary, 2);
                Console.WriteLine("\nBinary: " + binary + "\nDenary: " + denary);
            }
            Console.ReadKey();
        }
    }
}
