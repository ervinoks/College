using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W133
{
	internal class Program
	{
		static IDictionary<int, long> _memo = 
			new Dictionary<int, long>{ { 0, 0 }, { 1, 1 } };
		static void Main(string[] args)
		{
			for (int i = 0; i < 51; i++)
			{
				Console.WriteLine($"Fib({i}) = {Fib(i)}"); // memoisation
			}
			Console.ReadKey();
		}
		static long Fib(int n)
		{
			if (_memo.ContainsKey(n)) { return _memo[n]; }
			long value = Fib(n - 1) + Fib(n - 2);
			_memo[n] = value;
			return value;
		}
	}
}
