using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A222
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintErrors(Errors("uuaaaxbbbbyyhwawiwjjjwwxymzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz"));
			Console.WriteLine("\n");
			PrintErrors(Errors("wpetrificusutotalusuwuexpectoupatronumuwuwingardiumuleviosauwu"));
			Console.ReadKey();
		}
		static Dictionary<char, int> Errors(string Print)
		{
			Predicate<char> CheckErrors = (char C) => { return new char[] { 'u', 'w', 'x', 'z' }.Contains(C); };
			Dictionary<char, int> errors = new Dictionary<char, int>() { { 'u', 0 }, { 'w', 0 }, { 'x', 0 }, { 'z', 0 } };
			foreach (char c in Print)							  
			{
				if (CheckErrors(c))
				{
					errors[c] += 1;
				}
			}
			return errors;
		}
		static void PrintErrors(Dictionary<char, int> Errors)
		{
			for (int i = 0; i < Errors.Count; i++)
			{
				char key = Errors.ElementAt(i).Key; int value = Errors.ElementAt(i).Value;
				Console.WriteLine(key + "  " + value + new string(' ', 5 - value.ToString().Length) + new string('*', value));
			}
		}
	}
}
