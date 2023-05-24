using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W112
{
	internal class Basics
	{
		static void Main(string[] args)
		{
			string fileName = "MyFile.txt";
			string filePath = $@"{Directory.GetCurrentDirectory()}\..\..";
			Directory.SetCurrentDirectory(filePath);
			string contents = File.ReadAllText(fileName);
			Console.Write($"{contents}\n\n");
			Console.ReadKey(true);
			using (StreamReader sr = new StreamReader("MyFile.txt"))
			{
				string line;
				while (sr.EndOfStream == false) { line = sr.ReadLine(); Console.Write(line); }
			}
			Console.ReadKey();
		}
	}
}
