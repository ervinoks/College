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
            double price = double.Parse(Console.ReadLine());
            const int VAT = 20; //sets VAT as a constant
            string totalPrice = "£" + String.Format("{0:0.00}", price + (VAT * price / 100)); //formats the price to 2d.p. and calculates the VAT from 20% to 0.20
            Console.WriteLine("VAT is " + VAT + "%, making your total price: " + totalPrice);
            Console.ReadKey();
        }
    }
}
