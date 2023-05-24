using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A100
{
    internal class SlabCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of slabs across");
            int slabsAcross = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number of slabs deep");
            int slabsDeep = int.Parse(Console.ReadLine());
            Console.WriteLine("Input price of a slab");
            Console.Write("£");
            double slabPrice = double.Parse(Console.ReadLine());
            double totalPrice = slabsAcross * slabsDeep * slabPrice;
            string strtotalPrice = "£" + String.Format("{0:0.00}", totalPrice); //formats the price to 2d.p.
            Console.WriteLine("Your total price: " + strtotalPrice);
            Console.ReadKey();
        }
    }
}
