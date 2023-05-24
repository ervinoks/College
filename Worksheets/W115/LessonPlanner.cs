using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W115
{
	internal class LessonPlanner
	{
		struct Lesson
		{
			public string teacherName, room;
			public int numberOfStudents;
		}
		static void Main(string[] args)
		{
			string fileName = "MyFile.bin", filePath = Directory.GetCurrentDirectory();
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			List<Lesson> lessonsToWrite = new List<Lesson>();
			Lesson tempLesson;
			//Populate list of structures
			tempLesson.teacherName = "Mr White";
			tempLesson.room = "C10H15N";
			tempLesson.numberOfStudents = 1;
			lessonsToWrite.Add(tempLesson);

			tempLesson.teacherName = "Mr Allen";
			tempLesson.room = "21";
			tempLesson.numberOfStudents = 15;
			lessonsToWrite.Add(tempLesson);
			//Write list of structures to file
			using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
			{
				//Write the length of the list. We'll need that later
				writer.Write(lessonsToWrite.Count);
				//Followed by data for each of the structures
				for (int i = 0; i < lessonsToWrite.Count; i++)
				{
					writer.Write(lessonsToWrite[i].teacherName);
					writer.Write(lessonsToWrite[i].room);
					writer.Write(lessonsToWrite[i].numberOfStudents);
				}
			}
			//read list of lessons from file, in the same format as was written
			List<Lesson> lessonsRead = new List<Lesson>();
			using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate)))
			{
				//read how many are stored
				int numLessons = reader.ReadInt32();
				for (int i = 0; i < numLessons; i++)
				{
					//read each one into a separate structure
					tempLesson.teacherName = reader.ReadString();
					tempLesson.room = reader.ReadString();
					tempLesson.numberOfStudents = reader.ReadInt32();
					lessonsRead.Add(tempLesson);
				}
			}
		}
	}
}
