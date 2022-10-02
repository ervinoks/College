using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L105
{
	internal class LoopOfLoops
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input your first number:");
			int first = int.Parse(Console.ReadLine());
			Console.WriteLine("Input your max number:");
			int max = int.Parse(Console.ReadLine());
			Console.WriteLine("Input step size:");
            int step = int.Parse(Console.ReadLine());
			int current = first;
            for (int i = 0; i < first; current += step);

			Console.ReadKey();
		}
	}
}
