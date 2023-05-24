using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W128
{
	internal class Box
	{
		private float height, width, length;
		public Box(float height, float width, float length)
		{
			this.height = height; this.width = width; this.length = length;
        }
		public float GetHeight()
		{
			Console.Write("Input the height: ");
			return float.Parse(Console.ReadLine());
        }
        public float GetWidth()
        {
            Console.Write("Input the width: ");
            return float.Parse(Console.ReadLine());
        }
		public float GetLength()
		{
			Console.Write("Input the length: ");
			return float.Parse(Console.ReadLine());
		}
        public double CalculateVolume() => height * width * length;
		public double CalculateSurfaceArea() => 2 * height + 2 * width + 2 * length;
	}											   
}
