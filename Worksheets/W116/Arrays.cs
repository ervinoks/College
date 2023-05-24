using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W116
{
	internal class Arrays
	{
		static void Main(string[] args)
		{
			string[] array = { "foo", "bar", "for", "baz" }; int index = 0; bool parsed = false;
            do
            {
                try
                {
                    Console.Write("Enter an index to display an element from an array: ");
                    parsed = int.TryParse(Console.ReadLine(), out index);
                    if (parsed == false) { throw new FormatException(); }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message} Please enter an integer.");
                }
            } while (parsed == false);
            Console.WriteLine($"Your string at index '{index}' is \"{array[index]}\"");
			Console.ReadKey();
		}
	}
}
