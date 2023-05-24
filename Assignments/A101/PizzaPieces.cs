using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A101
{
    internal class PizzaPieces
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input diameter (cm):");
            int diameter = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of slices:");
            int slices = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of slices eaten:");
            int eaten = int.Parse(Console.ReadLine());
            const int thickness = 2;
            double volume = Math.PI * diameter / 2 * eaten / slices * thickness;
            Console.WriteLine(volume + "cm^3 of pizza eaten");
            Console.ReadKey();
        }
    }
}