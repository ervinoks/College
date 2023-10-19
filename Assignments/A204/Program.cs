using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using A202;

namespace A204
{
	class Program
	{
		static void Main(string[] args)
		{

			Vowels("bacterious");
			Console.WriteLine();
			Vowels("nouveau");
			Console.WriteLine("\n");
			Pendulum(new int[] { 6, 9, 14, 1, 3 });
			Console.WriteLine();
			Pendulum(new int[] { -3, 5, 2, 1, -7, 8});
			Console.ReadKey();
		}
		static void Vowels(string input)
		{
			char[] vowels = { 'a', 'e', 'i', 'o', 'u'};
			List<char> inputVowels = new List<char>();
			foreach (char c in input)
			{
				if (vowels.Contains(c))
					inputVowels.Add(c);
				else 					
					Console.Write(c);
			}
			Console.WriteLine(string.Join("", inputVowels));
		}
		static void Pendulum(int[] input)
		{
			input = Sort.BubbleSort(input);	// using A202;
			int len = input.Length, mid;
			if (len < 3) throw new ArgumentOutOfRangeException
					("Array must have at least 3 elements");
			else if (len % 2 == 0)
				mid = (len - 1) / 2;
			else
				mid = len / 2;
			int[] output = new int[len];
			output[mid] = input[0];
			int left = mid - 1, right = mid + 1;
			for (int i = 1; i < len; i++)
			{
				if (i % 2 == 0)
				{
					output[left] = input[i];
					left--;
				}
				else
				{
					output[right] = input[i];
					right++;
				}
			}
			Console.WriteLine(string.Join(", ", output));
		}
	}
}
