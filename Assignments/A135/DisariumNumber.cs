using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A135
{
	internal class DisariumNumber
	{
		static void Main(string[] args)
		{
			int _; // saves me rewriting
			Console.WriteLine($"{_ = 175}: {Disarium(_)}");
			Console.WriteLine($"{_ = 375}: {Disarium(_)}");
			Console.WriteLine($"{_ = 518}: {Disarium(_)}");
			Console.ReadKey();
		}
		static bool Disarium(int num)
		{
			int _tot = default;
			for (int i = 0; i < num.ToString().Length; i++)
				_tot += (int)Math.Pow(int.Parse(num.ToString()[i].ToString()), i + 1);
			return _tot == num;
		}
	}
}
