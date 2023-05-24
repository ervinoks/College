using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L152
{
	internal class MyStack<T>
	{
		private int top;
		private T[] values;
		public MyStack(int size)
		{
			top = -1;
			values = new T[size];
		}
		public void Push(T value)
		{
			values[top = top + 1] = value;
		}
		public T Pop()
		{
			top = top - 1;
			return values[top + 1];
		}
		public T Peek()
		{
			return values[top];
		}
		public bool IsEmpty()
		{
			return top == -1;
		}
		public bool IsFull()
		{
			return top == values.Length - 1;
		}
	}
}
