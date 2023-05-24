using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W126
{
	internal class Course
	{
		public string Subject;
		public List<Student> Register = new List<Student>();
		public bool EnrolStudent(Student student) 
		{
			if (Register.Contains(student)) { return false; }
			else { Register.Add(student); SortRegister(); return true; }
		}
		public void SortRegister() // insertion sort
		{
			for (int i = 0; i < Register.Count - 1; i++)
            {
				for (int j = i + 1; j > 0; j--)
                {
					if (Register[j - 1].Name[0] > Register[j].Name[0])
                    {
                        var temp = Register[j - 1];	 //change to student
                        Register[j - 1] = Register[j];
						Register[j] = temp;
                    }
                }
            }

		}
		public void DisplayRegister()
		{
			Console.WriteLine($"Course subject: {Subject}");
			Console.WriteLine();
			foreach (Student student in Register)
			{
				Console.WriteLine($"Name: {student.Name}" +
					$"\nPresent last lesson: {(student.PresentLastLesson ? 'y' : 'n')}");
				Console.WriteLine();
			}
		}
		public void TakeRegister()
		{
			foreach (Student student in Register)
			{
				Console.Write($"Is {student.Name} present (y/n): ");
				char input = Console.ReadKey().KeyChar;
				Console.WriteLine();
				switch (input)
				{
					case 'y':
						student.PresentLastLesson = true;
						break;
					case 'n':
						student.PresentLastLesson = false;
						break;
				}
			}
			Console.WriteLine();
		}
	}
}
