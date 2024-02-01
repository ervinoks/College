using System.Diagnostics;

namespace L203
{
	public class Vector
	{
		public double[] dimensions;
		public Vector(params double[] args)
		{
			Debug.Assert(args.Count() >= 2, "Not enough dimensions");
			dimensions = args;
		}
		public Vector(int dimensionNum)
		{
			dimensions = new double[dimensionNum];
			Debug.Assert(dimensionNum >= 2, "Not enough dimensions");
			for (int i = 0; i < dimensionNum; i++) { dimensions[i] = 0; }
		}
		public static Vector operator +(Vector a) => a;
		public static Vector operator -(Vector a)
		{
			Vector b = a;
			for (int i = 0; i < a.dimensions.Length; i++)
			{
				b.dimensions[i] = -a.dimensions[i];
			}
			return b;
		}
		public static Vector operator +(Vector a, Vector b)
		{
			Debug.Assert(a.dimensions.Length == b.dimensions.Length, "Vectors must be the same dimension");
			Vector c = new(a.dimensions.Length);
			for (int i = 0; i < a.dimensions.Length; i++)
			{
				c.dimensions[i] = a.dimensions[i] + b.dimensions[i];
			}
			return c;
		}
		public static Vector operator -(Vector a, Vector b) => a + -b;
		public static Vector operator *(Vector a, double b)
		{
			Vector c = a;
			for (int i = 0; i < a.dimensions.Length; i++)
			{
				c.dimensions[i] *= b;
			}
			return c;
		} //operator overloading
		public static Vector operator *(double b, Vector a) => a * b;
		//{
		//	Vector _c = new();
		//	for (int i = 0; i < a.dimensions.Length; i++) 
		//	{
		//		 = a.dimensions[i] += b.dimensions[i];
		//	}

		//}
	}
}
