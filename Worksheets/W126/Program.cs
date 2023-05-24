using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W126
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student stud1 = new Student(); Student stud2 = new Student();
			stud1.Name = "Ervin"; stud1.Age = 16;
			stud2.Name = "Sam"; stud2.Age = 18;
			Course course1 = new Course();
			course1.Subject = "Computer Science";
			if (course1.EnrolStudent(stud2)) { Console.WriteLine($"{stud2.Name} was enrolled successfully"); }
			else { Console.WriteLine($"{stud2} was not enrolled successfully"); } 
			if (course1.EnrolStudent(stud1)) { Console.WriteLine($"{stud1.Name} was enrolled successfully"); }
			else { Console.WriteLine($"{stud1} was not enrolled successfully"); }
			course1.TakeRegister();
			course1.DisplayRegister();
			Console.ReadKey();
		}
	}
}
