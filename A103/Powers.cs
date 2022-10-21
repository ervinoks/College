using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A103
{
    internal class Powers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your power table:");
            int tablePower = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the highest power you want to see:");
            int highestPower = int.Parse(Console.ReadLine());
            int currentPower = -1;
            do
            {
                if (currentPower % 2 == 0) Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{tablePower, 1} ^ {currentPower += 1, -10} = {Math.Pow(tablePower, currentPower), 30}");
                Console.ForegroundColor = ConsoleColor.Gray;
            } while (currentPower < highestPower);

            Console.ReadKey();
        }
    }
}