using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L134
{
	internal class BinaryFiles
	{
		static void Main(string[] args)
		{
			string fileName = "myFile.bin";
			string filePath = Directory.GetCurrentDirectory();
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
			{
				writer.Write(5);
				writer.Write("Hello, world");
				writer.Write(true);
			}
			int myInt = 0;
			string myString = "";
			bool myBool = false;
			using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate)))
			{
				myInt = reader.ReadInt32();
				myString = reader.ReadString();
				myBool = reader.ReadBoolean();

				Console.WriteLine($"{myInt}, {myString}, {myBool}");
			}
			Console.ReadKey();
		}
	}
}
