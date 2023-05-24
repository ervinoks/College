using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L166
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string Test1 = "...D...M...C..";
			string Test2 = "...C.......D.....M....";
			string Test3 = "M......C........D";
			Console.WriteLine($"Test 1: {Test1} ~ {Jump(Test1, 5)}" +
				$"\nTest 2: {Test2} ~ {Jump(Test2, 15)}" +
				$"\nTest 3: {Test3} ~ {Jump(Test3, 5)}");
			Console.ReadKey();
		}
		static string Jump(string area, int j)
		{
			int cat = area.IndexOf('C');
			int mouse = area.IndexOf('M');
			int dog = area.IndexOf('D');
			if (Math.Abs(cat - mouse) < j)
				if ((mouse < dog && dog < cat) || (mouse > dog && dog > cat))
					return "Protected!";
				else
					return "Caught!";
			else
				return "Escaped!"; 
		}
	}
}
