using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L100
{
    internal class FirstProgram
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numSubjects = int.Parse(Console.ReadLine());
            Console.WriteLine(name, "takes", numSubjects, "subjects");
            Console.ReadKey();
        }
    }
}
