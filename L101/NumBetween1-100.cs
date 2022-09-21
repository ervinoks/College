using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter age: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age <= 18)
            //{
            //    Console.Write("young");
            //}
            //else if (age > 18 && age <= 25)
            //{
            //    Console.Write("young adult");
            //}
            //else if (age > 25)
            //{
            //    Console.Write("old : (");
            //}

            Console.Write("Input a number");
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                Console.Write("Your number is between 1 and 100.");
            }
            else if (num < 1)
            {
                Console.Write("Your number is too small.");
            }
            else if (num > 100)
            {
                Console.Write("Your number is too big.");
            }
            Console.ReadKey();

        }
    }
}