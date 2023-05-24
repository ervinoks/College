using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A102
{
    internal class TrafficLights
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current traffic light? (Red, RedAmber, Green, Amber)");
            string currentLight = Console.ReadLine().ToLower();
            switch (currentLight)
            {
                case "red":
                    Console.WriteLine("RedAmber");
                    break;
                case "redamber":
                    Console.WriteLine("Green");
                    break;
                case "green":
                    Console.WriteLine("Amber");
                    break;
                case "amber":
                    Console.WriteLine("Red");
                    break;
            }
            Console.ReadKey();
        }
    }
}