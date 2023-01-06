using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W111
{
	internal class PersonalData
	{
		struct Person { public string title, forename, surname, favouriteColour; public int age; }
		static Func<Person, string> DisplayPerson = person => 
		$"\rTitle: {person.title} \nForename: {person.forename} \nSurname: {person.surname} \nAge: {person.age} \nFavourite Colour: {person.favouriteColour}";
		static Person InputPerson()
		{
			Person peep;
			Console.WriteLine("What's your title?"); peep.title = Console.ReadLine();
			Console.WriteLine("What's your forename?"); peep.forename = Console.ReadLine();
			Console.WriteLine("What's your surname?"); peep.surname = Console.ReadLine();
			Console.WriteLine("What's your age?"); peep.age = int.Parse(Console.ReadLine());
			Console.WriteLine("What's your favourite colour?"); peep.favouriteColour = Console.ReadLine();
			return peep;
		}
		static void Main(string[] args)
		{
			Person myself = new Person { title = "Mr", forename = "Ervin", surname = "Oks", age = 16, favouriteColour = "blue" };
			Console.WriteLine(DisplayPerson(myself));
			Console.WriteLine(DisplayPerson(InputPerson()));
			Console.ReadKey();
		}
	}
}