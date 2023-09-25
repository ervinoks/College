using System;
using System.Numerics;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

namespace WX_Multithreading
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			InitArray();
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		static int ITEMS = 100000;

		static int[] arr = new int[ITEMS];

		[ThreadStatic]
		static Random rnd;

		static void InitArray()
		{
			rnd = new();
			Parallel.For(0, ITEMS, init =>
				{
					arr[init] = arr[rnd.Next()];
				});
		}

		//public static int ParallelForWithLocalFinally()
		//{
		//	int total = 0;
		//	int parts = 8;
		//	int partSize = ITEMS / parts;
		//	var parallel = Parallel.For(0, parts,
		//		localInit: () => 0L, // Initializes the "localTotal"
		//		body: (iter, state, localTotal) =>
		//		{
		//			for (int j = (int)iter * partSize; j < (iter + 1) * partSize; j++)
		//			{
		//				localTotal += arr[j];
		//			}

		//			return localTotal;
		//		},
		//		localFinally: (localTotal) => { total += (int)localTotal; });
		//	return total;
		//}
	}
}