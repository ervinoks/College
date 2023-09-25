using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A201
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter start map: ");
			string map = Console.ReadLine();
			(string map, int total, int infected) world = Pandemic(map.ToCharArray());
			Console.WriteLine($"End map: {world.map}");
			Console.WriteLine($"Total: {world.total}");
			Console.WriteLine($"Infected: {world.infected}");
			Console.WriteLine($"Percentage: {Math.Round((float)world.infected / (float)world.total * 100)}%");
			Console.ReadKey();
		}
		private static (string map, int total, int infected) Pandemic(char[] map)
		{
			bool infect = true;
			int oceanCount = 0; 
			(int prev, int current) oceanIndex = (-1, -1);
			for (int i = 0; i < map.Length; i++)
			{
				if (map[i] == 'X')
				{
					oceanCount++;
					if (oceanCount > 0) oceanIndex.prev = oceanIndex.current;
					oceanIndex.current = Array.IndexOf(map, 'X', oceanIndex.prev + 1);
					if (infect == true) spread();
					infect = false;
				}
				else if (map[i] == '1')
				{
					infect = true;
				}
				if (infect == true && i == 0) spread();
			}
			void spread()
			{
				for (int j = oceanIndex.prev + 1; j < oceanIndex.current; j++)
				{
					map[j] = '1';
				}
			}
			int infected = map.Count(c => c == '1');
			return (new string(map), map.Count(c => c == '0') + infected, infected);
		}
	}
}
