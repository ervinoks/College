using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L101
{
    internal class Driving
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year were you born?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born?");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("What day were you born?");
            int day = int.Parse(Console.ReadLine());
            int yearDifference = int.Parse(DateTime.Now.ToString("yyyy")) - year;
            if (yearDifference == 17) { Console.WriteLine("You can drive!"); }
            else
            {
                Console.WriteLine("You can't drive.");
                Console.ReadKey();
            }
        }
    }
}
