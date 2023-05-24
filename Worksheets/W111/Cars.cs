using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W111
{
	internal class Cars
	{
		struct Car { public string colour, make, model; public int value; }
		static Car GetCar()
		{
			Car car;
			Console.WriteLine("What's the car's colour?"); car.colour = Console.ReadLine();
			Console.WriteLine("What's the car's make?"); car.make = Console.ReadLine();
			Console.WriteLine("What's the car's model?"); car.model = Console.ReadLine();
			Console.WriteLine("What's the car's value?"); car.value = int.Parse(Console.ReadLine());
			return car;
		}
		static Func<Car, string> DisplayCar = car =>
		$"\rColour: {car.colour} \nMake: {car.make} \nModel: {car.model} \nValue: {car.value}";
		static void Main(string[] args)
		{

		}
	}
}
