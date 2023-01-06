using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace L118
{
    internal class NameDuplicator
    {
        static List<string> names = new List<string>();
        static TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;
        static void NameInput()
        {
            bool done = false;
            do
            {
                Console.Write("Enter a name, or 'done' to stop: ");
                string output = textInfo.ToTitleCase(Console.ReadLine());
                if (output == "Done") { done = true; }
                else { names.Add(output); }
            } while (done == false);
        }
        static void Main(string[] args)
        {
            NameInput();
            List<string> uniqueNames = names.Distinct().ToList();
            Console.WriteLine("[" + string.Join(", ", uniqueNames) + "]");
            Console.ReadKey();
        }
    }
}