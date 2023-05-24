using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101
{
    internal class IfTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            if (age <= 18)
            {
                Console.Write("young");
            }
            else if (age > 18 && age <= 25)
            {
                Console.Write("young adult");
            }
            else if (age > 25)
            {
                Console.Write("old : (");
            }
            Console.ReadLine();
        }
    }
}