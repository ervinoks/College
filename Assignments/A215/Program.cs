using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A215
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int DADoorperson(string word) => (word.IndexOf(word.First(c => c == (word[word.IndexOf(c) + 1]))) + 1) * 3;
			Console.WriteLine($"potter: {DADoorperson("potter")}\ntarantallegra: {DADoorperson("tarantallegra")}");
			Console.ReadKey();
		}
	}
}
