﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A202
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] nums = { 93, 46, 85, 90, 66, 57, 75, 5, 33, 45 };
			Console.WriteLine($"Unsorted array: {string.Join(", ", nums)}\n");
			for (int i = 0; i < nums.Length; i++)
			{
				bool noSwaps = true;
				int checkNum = nums[0];
				for (int j = 1; j < nums.Length; j++)
				{
					if (nums[j] < checkNum)
					{
						nums[j - 1] = nums[j];
						nums[j] = checkNum;
						noSwaps = false;
					}
					else
					{
						checkNum = nums[j];
					}
				}
				if (noSwaps) break;
			}
			Console.WriteLine($"Sorted array: {string.Join(", ", nums)}");
			Console.ReadKey();
		}
	}
}
