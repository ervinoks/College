using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W134
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IQueue<int> LinearQueue = new LinearQueue<int>(5);
			LinearQueue.Enqueue(1);
			LinearQueue.Enqueue(2);
			LinearQueue.Enqueue(3);
			LinearQueue.Enqueue(4);
			LinearQueue.Enqueue(5);
			LinearQueue.Enqueue(6);
			Console.WriteLine(LinearQueue.Dequeue());
			Console.WriteLine(LinearQueue.Dequeue());
			Console.WriteLine(LinearQueue.Dequeue());
			Console.ReadKey();
		}
	}
}
