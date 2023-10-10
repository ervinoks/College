using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A203
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] A = { 2, 6, 14, 24, 39, 57, 63, 88 };
			int searchNum = int.Parse(Console.ReadLine());
			Console.WriteLine(BinarySearch(A, searchNum));
			Console.ReadKey();
		}
		static string BinarySearch(int[] array, int num)
		{
			int len = array.Length,
				mid = (len / 2) - 1, 
				lb = 0, 
				ub= len - 1;
			bool solved = false;
			int count = 0;
			while (solved == false)
			{
				mid = (ub + lb) / 2;
				if (count >= Math.Log(array.Length))
					break;
				int midVal = array[mid];
				if (midVal < num)
				{
					lb = mid + 1;
					count++;
				}
				else if (midVal > num)
				{
					ub = mid - 1;
					count++;
				}
				else
					solved = true;
			}
			return solved ? $"Found {num} at index {mid}" : $"Could not find {num} in array";
		}
	}
}
