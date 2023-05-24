using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L114
{
    internal class Password
    {
        static void Main(string[] args)
        {
            Console.Write("Input your first name: ");
            string firstName = Console.ReadLine().ToUpper();
            Console.Write("Input your last name: ");
            string lastName = Console.ReadLine().ToUpper();
            Console.Write("Input your year of birth: ");
            string birthYear = Console.ReadLine();
            Console.Write("Input your favourite colour: ");
            string favColour = Console.ReadLine();
            Console.Write("Input the name of your street: ");
            string streetName = Console.ReadLine();
            Console.Write("Input your shoe size: ");
            string shoeSize = Console.ReadLine();
            string Password = firstName.Substring(0,1) + lastName.Substring(1,1) + birthYear.Substring(2, 2) + favColour.Substring(1, 2) + streetName.Substring(0, 3) + shoeSize.Substring(0,1);
            Console.WriteLine();
            Console.WriteLine($"Your super secure new password is: {Password}");
            Console.ReadKey();
        }
    }
}
