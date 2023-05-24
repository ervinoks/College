using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A114
{
	internal class Program
	{
		struct film
		{
			public string title;
			public int runtime;
			public bool currentOn;
		}
		static void Main(string[] args)
		{
			string filename, filePath = Directory.GetCurrentDirectory(), choice;
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			List<film> filmList = new List<film>();
			int numOfFilms;

			do
			{
				choice = menuchoice();
				switch (choice)
				{
					case "1":
						filename = getfilename();
						filmList = readBinaryFile(filename);
						displayList(filmList);
						break;
					case "2":
						filename = getfilename();
						numOfFilms = getNumOfFilms();
						filmList = getFilmInfo(numOfFilms);
						writeBinaryFile(filename, numOfFilms, filmList); 
						break;
					case "9":
						System.Environment.Exit(1);
						break;
					default:
						break;
				}
			} while (true);
		}
		static List<film> readBinaryFile(string filename)
		{
			List<film> filmList = new List<film>();
			film Film;

			using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.OpenOrCreate)))
			{
				int numOfFilms = reader.ReadInt32();
				while (reader.PeekChar() > -1)
				{
					Film.title = reader.ReadString();
					Film.runtime = reader.ReadInt32();
					Film.currentOn = reader.ReadBoolean();
					filmList.Add(Film);
				}
			}
			return filmList;
		}
		static void writeBinaryFile(string filename, int numOfFilms, List<film> filmList)
		{
			using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.OpenOrCreate)))
			{
				writer.Write(numOfFilms);
				foreach (film Film in filmList)
				{
					writer.Write(Film.title);
					writer.Write(Film.runtime);
					writer.Write(Film.currentOn);
				}
			}
		}
		static string getfilename()
		{
			string filename;
			Console.WriteLine("Enter name of file including extension");
			filename = @Console.ReadLine();
			return filename;
		}
			static int getNumOfFilms()
		{
			int numOfFilms;
			Console.WriteLine("How many films do you want to enter?");
			numOfFilms = int.Parse(Console.ReadLine());
			return numOfFilms;
		}
		static void displayList(List<film> filmList)
		{
			Console.WriteLine("Title".PadRight(30) + "Run Time".PadLeft(8) + "Current".PadLeft(10));
			for (int i = 0; i < filmList.Count; i++)
			{
				Console.WriteLine(filmList[i].title.PadRight(30) + " " + filmList[i].runtime.ToString().PadLeft(7) + filmList[i].currentOn.ToString().PadLeft(10));
			}
			Console.WriteLine();
		}
		static List<film> getFilmInfo(int numOfFilms)
		{
			List<film> listOfFilms = new List<film>();
			film tempFilm = new film();
			for (int i = 0; i < numOfFilms; i++)
			{
				Console.WriteLine("Enter film title");
				tempFilm.title = Console.ReadLine();
				Console.WriteLine("Enter film running time");
				tempFilm.runtime = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter if film is currently on (true or false)");
				tempFilm.currentOn = bool.Parse(Console.ReadLine());
				listOfFilms.Add(tempFilm);
			}
			return listOfFilms;
		}
		static string menuchoice()
		{
			string choice;
			menu();
			choice = Console.ReadLine();
			return choice;
		}
		static void menu()
		{
			Console.WriteLine("The Barton Cinema Files");
			Console.WriteLine();
			Console.WriteLine("1. Read in film information from a binary file");
			Console.WriteLine("2. Write film information into a binary file");
			Console.WriteLine();
			Console.WriteLine("9. Exit");
			Console.WriteLine();
			Console.WriteLine("Please type in the number of your choice");
		}
	}
}
