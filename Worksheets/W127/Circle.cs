using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W127
{
	internal class Circle
	{
		private double radius;
		public Circle(double value) => radius = value;
		public double getArea() => Math.PI * Math.Pow(radius, 2);
		public double getCircumference() => 2 * radius * Math.PI;
	}
}
