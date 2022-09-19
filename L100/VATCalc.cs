using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class VATCalc
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price: £");
            int price = int.Parse(Console.ReadLine());
            const int VAT = 20;
            string totalPrice = "£" + String.Format("{0:0.00}", price + (VAT * price / 100));
            Console.WriteLine("VAT is " + VAT + "%, making your total price: " + totalPrice);
            Console.ReadKey();
        }
    }
}
