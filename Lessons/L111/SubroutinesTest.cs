using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L111
{
	internal class SubroutinesTest
	{
		static int amountOfPasta = 6;
		static void Monarch()
		{
			amountOfPasta += 1;
			Console.WriteLine("King Charles the III");
		}
		static void Pasta()
		{
			Console.WriteLine($"You received {amountOfPasta} pasta!");
		}
		static void Main(string[] args)
        {
            Console.WriteLine(args);
			Pasta();
            Monarch();
			Pasta();
			Console.ReadKey();
		}
	}
}