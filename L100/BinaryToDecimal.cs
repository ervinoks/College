using System;
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
            //string binary = "";
            Console.WriteLine("How long is your binary digit?");
            int range = int.Parse(Console.ReadLine());
            Console.WriteLine("Most significant digit, or least significant digit first? (MSB/LSB)");
            string significance = Console.ReadLine().ToUpper();
            List<int> digits = new List<int>(range) { };
            if (significance == "MSB")
            {
                for (int i = 0; i < range; i++)
                {
                    digits.Add(int.Parse(Console.ReadLine()));
                }
                string binary = String.Join("", digits);
                int denary = Convert.ToInt32(binary, 2);
                Console.WriteLine("\nBinary: " + binary + "\nDenary: " + denary);
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
