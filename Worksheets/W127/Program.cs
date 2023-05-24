using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace W127
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Input a value for the radius: ");
			double radius = double.Parse(Console.ReadLine());
			Circle MyCircle = new Circle(radius);
			Console.WriteLine($"Radius: {radius}" +
				$"\nArea: {MyCircle.getArea()}" +
				$"\nCircumference: {MyCircle.getCircumference()}");
			Console.ReadKey(false);
		}
	}
}
