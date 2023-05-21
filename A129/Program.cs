using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A129
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pattern(11));
            string str1 = "5t4r Wa|^$", str2 = "L3_37";
            Console.WriteLine($"Is \"{str1}\" unique: {unique(str1)}\n");
            Console.WriteLine($"Is \"{str2}\" unique: {unique(str2)}");
            Console.ReadKey();
        }
        static string pattern(int n)
        {
            string patternStr = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    patternStr += i;
                }
                patternStr += "\n";
            }
            return patternStr;
        }
        static bool unique(string str)
        {
            List<char> chars = new List<char>();
            foreach (char c in str)
            {
                if (chars.Contains(c)) return false;
                else chars.Add(c);
            }
            return true;
        }
    }
}
