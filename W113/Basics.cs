using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W113
{
	internal class Basics
	{
		static void Main(string[] args)
		{
			string fileName = "MyFile.txt";
			string filePath = $@"{Directory.GetCurrentDirectory()}\..\..";
			Directory.SetCurrentDirectory(filePath);
			File.WriteAllText(fileName, "Hello World");
			Console.ReadKey();
		}
	}
}
