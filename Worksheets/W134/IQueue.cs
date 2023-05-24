using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W134
{
	public interface IQueue<T>
	{
		void Enqueue(T item);
		T Dequeue();
		bool IsEmpty();
		bool IsFull();
	}
}
