using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L152
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyStack<int> stack = new MyStack<int>(5);
			stack.Push(5);
			stack.Push(10);
			Console.WriteLine(stack.Pop() + stack.Peek());
			Console.ReadKey();
		}
	}
}
