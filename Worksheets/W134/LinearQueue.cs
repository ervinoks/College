using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W134
{
	internal class LinearQueue<T> : IQueue<T>
	{
		private int front, rear;
		private T[] queue;
		public LinearQueue(int maxSize)
		{
			front = 0;
			rear = -1;
			queue = new T[maxSize];
		}
		public void Enqueue(T value)
        {
            try
            {
				if (!IsFull()) { queue[++rear] = value; }
            }
            catch (IndexOutOfRangeException ex)
            {
				Console.WriteLine(ex.Message);
            } 
		}
		public T Dequeue()
		{
			if (IsEmpty()) { return default; }
			try { return queue[front]; }
			finally { queue[++front] = default; }   
		}
		public bool IsEmpty() => front == rear + 1;
		public bool IsFull() => queue.Count() == rear + 1;
    }
}
