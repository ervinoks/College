using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L157
{
	internal class Program
	{
		static int LinearSearch(int[] array, int searchNum)
		{
			bool foundNum = false; int i = -1;
			do
			{
				i++;
				if (array[i] == searchNum) { foundNum = true; }
			} while (!foundNum);
			return i;
		}
		static int[] sortedNums = new int[50];
		static void NumsArray()
		{
			for (int i = 1; i <= 50; i++)
			{
				sortedNums[i - 1] = i;
			}
		}
		static List<int> unsortedNums = new List<int>();
		static void NumsList()
		{
			Random random = new Random();
			for (int i = 0; i < 10; i++)
			{
				unsortedNums.Add(random.Next(200));
			}
		}
		static void BubbleSort(List<int> list) // from smallest to largest
		{
			bool sorted = false;
            do
            {
				for (int j = 0; j < list.Count / 2; j++)
                {
					for (int i = 0; i < list.Count - 1; i++)
					{
						int firstInt = list[i];
						int secondInt = list[i + 1];
						if (firstInt > secondInt)
						{
							list.Reverse(i, 2);
						}
					}
                }
				sorted = true;
            } while (!sorted);

        }
		static void Main(string[] args)
        {
            NumsArray();
            NumsList();
			BubbleSort(unsortedNums);
			Console.ReadKey();
        }
    }
}
