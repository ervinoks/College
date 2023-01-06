using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L118
{
    internal class Converters
    {
        static void ArrayToList()
        {
            int[] primesArray = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            List<int> primesList = primesArray.ToList();
            Console.WriteLine("[" + string.Join(", ", primesList) + "]");
        }
        static void ListToArray()
        {
            List<int> triangleList = new List<int> { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91 };
            int[] triangleArray = triangleList.ToArray();
            Console.WriteLine("[" + string.Join(", ", triangleArray) + "]");
        }
        static void Main(string[] args)
        {
            ArrayToList();
            ListToArray();
            Console.ReadKey();
        }
    }
}
