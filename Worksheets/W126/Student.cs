using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W126
{
	internal class Student
	{
		public string Name;
		public int Age;
		public bool PresentLastLesson;
		public void GetInfoFromUser()
		{
			Student stud = new Student();
			Console.Write("Input name of the student: ");
			stud.Name = Console.ReadLine();
			Console.Write("Input age of the student: ");
			stud.Age = int.Parse(Console.ReadLine());
		}
	}
}
