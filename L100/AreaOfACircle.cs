using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class AreaOfACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to find out the area of a circle, or a cylinder?");
            string ans = Console.ReadLine().ToLower();
            if (ans == "circle")
            {
                Console.Write("Enter radius of the circle: ");
                int radius = int.Parse(Console.ReadLine());
                double circleArea = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine("Area = " + circleArea + " or " + (circleArea / Math.PI) + "pi");
            }
            else if (ans == "cylinder")
            {
                Console.Write("Enter radius of the cylinder: ");
                int radius = int.Parse(Console.ReadLine());
                Console.Write("Enter height of the cylinder: ");
                int height = int.Parse(Console.ReadLine());
                double cylinderArea = 2 * Math.PI * Math.Pow(radius, 2) * height;
                Console.WriteLine("Area = " + (cylinderArea) + " or " + (cylinderArea / Math.PI) + "pi");
            }
            Console.ReadKey();
        }
    }
}