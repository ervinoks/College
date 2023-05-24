using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace January_Assessment
{
    internal class Q6
    {
        static string CalculateGrade(int percentageMark)
        {
            if (percentageMark >= 80) { return "A"; }
            else if (percentageMark >= 70) { return "B"; }
            else if (percentageMark >= 60) { return "C"; }
            else if (percentageMark >= 50) { return "D"; }
            else if (percentageMark >= 40) { return "E"; }
            else { return "U"; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Module 1 mark: ");
            int module1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Module 2 mark: ");
            int module2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Module 1 grade: {CalculateGrade(module1)}");
            Console.WriteLine($"Module 2 grade: {CalculateGrade(module2)}");
            Console.WriteLine();
            int totalPercentage = (module1 + module2) / 2;
            Console.WriteLine($"Total percentage mark: {totalPercentage}");
            Console.WriteLine($"Total AS Grade: {CalculateGrade(totalPercentage)}");
            Console.ReadKey();
        }
    }
}
