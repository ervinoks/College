using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

using static System.Net.Mime.MediaTypeNames;

public class Person
{
	protected internal string name { get; set; }
	protected virtual int age { get; set; } 
	protected internal string title;

	public Person(string inTitle, string inName, int inAge)
	{
		title = inTitle;
		name = inName;
		age = inAge;
	}

	public virtual void Display()
	{
		Console.Write(name);
		Console.Write(" (Age: " + age + ")");
	}
}

public class Student /*Answer to (1) = */ : Person
{
	protected override int age 
	{
		get => age;
		set
		{
			if (14 > value || value > 19) throw new ArgumentOutOfRangeException("Age must be in-between 14 and 19");
			age = value;
		}
	}
	
	private /*Answer to (2) = */ bool firstYear;

	public Student(string inTitle, string inName, int inAge, bool inFirstYear) : base(inTitle, inName, /*Answer to (3) = */ inAge)
	{
		firstYear = inFirstYear;
	}

	public /*Answer to (4) = */ bool IsFirstYear()
	{
		return /*Answer to (5) = */ firstYear;
	}

	public override void Display()
	{
		base.Display();
		Console.Write(" (Year: " + (firstYear ? "1st" : "2nd") + ")");
	}
}

public class Teacher : Person
{
	private string subject;

	public Teacher(string inTitle, string inName, int inAge, string inSubject) : base(inTitle, inName, inAge)
	{
		subject = inSubject;
	}

	public override void Display()
	{
		Console.Write(name);
	}
}

public class Course
{
	private string subject;
	private List<Student> students;
	private Teacher teacher;

	public Course(string inSubject)
	{
		subject = inSubject;

		students = new List<Student>();
	}

	public void SetTeacher(string title, string name, int age)
	{
		teacher = new Teacher(title, name, age, subject);
	}

	public void AddStudent(Student s)
	{
		students.Add(s);
	}

	public void Display()
	{
		Console.WriteLine(subject);

		Console.Write("Teacher: ");
		teacher.Display();
		Console.WriteLine();

		Console.WriteLine("Students: ");

		// bubble sort
		Student _tempS;
		bool swap;
		do
		{
			swap = false;
			for (int i = 0; i < students.Count - 1; i++)
			{
				if (students[i].name.CompareTo(students[i + 1].name) > 0)
				{
					_tempS = students[i];
					students[i] = students[i + 1];
					students[i + 1] = _tempS;

				}
			}
		} while (swap);

		foreach (Student s in students)
		{
			s.Display();
			Console.WriteLine();
		}
	}
	
	public List<Student> GetFirstYearStudents()
	{
		List<Student> firstYearStudents = new List<Student>();
		foreach (Student s in students)
		{
			if (s.IsFirstYear())
			{
				firstYearStudents.Add(s);
			}
		}
		return firstYearStudents;
	}
}

internal class Program
{
	static void Main(string[] args)
	{
		Course compSci = new Course("Computer Science");
		compSci.SetTeacher("Dr.", "Matt", 24);

		compSci.AddStudent(new Student("Ms", "Alice", 16, true));
		compSci.AddStudent(new Student("Mr", "Bob", 17, true));
		compSci.AddStudent(new Student("Mx", "Elise", 17, false));
		compSci.AddStudent(new Student("Ms", "Charlotte", 16, true));
		compSci.AddStudent(new Student("Rev", "Dave", 17, false));
		compSci.AddStudent(new Student("Mr", "Fred", 18, false));

		compSci.Display();

		Console.ReadKey();
	}
}