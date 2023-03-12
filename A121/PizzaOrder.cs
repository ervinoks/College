using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A121
{
    internal class PizzaOrder
    {
        private string address;
        private int diameter;
        private List<string> toppings;
        public PizzaOrder(string addressToDeliver, int size, List<string> listOfToppings)
        {
            address = addressToDeliver;
            diameter = size;
            toppings = listOfToppings;
        }
        public int getPrice()
        {
            double price = ((Math.Pow((diameter / 2), 2) * Math.PI) / 10) + toppings.Count + 2;
            return (int)Math.Round(price);
        }
        public void getSummary()
        {
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Size: {diameter} inches");
            Console.WriteLine($"Toppings ({toppings.Count} total): ");
            foreach (string topping in toppings)
            {
                Console.WriteLine($"•{topping}"); 
            }
            Console.WriteLine($"Price: £{getPrice()}.00");
        }
    }
}
