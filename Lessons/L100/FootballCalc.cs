using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class FootballCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your team?");
            string teamName = Console.ReadLine();
            Console.WriteLine("How many wins?");
            int teamWins = int.Parse(Console.ReadLine());
            Console.WriteLine("How many draws?");
            int teamDraws = int.Parse(Console.ReadLine());
            Console.WriteLine("Total points for team " + teamName + " is " + (teamWins * 3 + teamDraws));
            Console.ReadKey();
        }
    }
}
