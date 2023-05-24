using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace L160
{
	//Structures used to temporaily hold the data taken from the database
	public struct pupil
	{
		public int id;
		public string forename;
		public string surname;
		public string house;
		public int age;
	}
	public struct Classes
	{
		public string name;
		public string teacher;
		public int id;
	}
	
	internal class Program
	{
		public static SQLiteConnection conn = new SQLiteConnection("Data Source=hogwarts.db;Version=3;New=True;Compress=True;"); 
		public static List<int> menuOptions = new List<int> { 1, 2, 3, 4, 9 };
		static void Main(string[] args)
		{	 
			string filePath = Directory.GetCurrentDirectory();
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			conn.Open();
			int Choice = -1;
			while (Choice != 9)
			{
				Console.Clear();
				mainmenu();
				do
				{
					Console.Write("\rPlease enter your choice: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); break; }
					Console.WriteLine("\nPlease input one of the numbers shown.");
					Console.CursorTop -= 2;
				} while (!menuOptions.Contains(Choice) &&  Choice != 4);
				Console.Clear();
				switch (Choice)
				{
					case 1:
						pupilsection();
						break;
					case 2:
						classsection();
						break;
					case 3:
						enrolsection();
						break;
				}
				if (Choice != 9)
				{
					Choice = -1;
				}
			}
			Console.WriteLine("Goodbye!");
			Console.ReadKey();
		}
		//The findpupil function has been used in viewpupil and deletepupil
		//HINT: It will be useful in enrolpupil and removeenrolment
		public static bool findpupil(ref pupil[] pupils, string surname, ref int count)
		{
			//This function will find all pupils with surname given.  
			//If more then than one pupil with same surname then allows user to choose one and adjusts variable count accordingly
			//Function returns true if pupil found, false if no pupil found with given surname
			//Pupil(s) found will be saved in the pupils structure which has been passed by reference
			//starts connection with database

			// Count the number first
			SQLiteDataReader rscount;
			SQLiteCommand sqlCount = new SQLiteCommand("select COUNT(*) AS count from pupils where surname = '" + surname + "' ", conn);
			rscount = sqlCount.ExecuteReader();
			rscount.Read();
			long numRows = (long)rscount["count"];
			string choice;
			SQLiteDataReader rspupils;
			SQLiteCommand sql = new SQLiteCommand("select * from pupils where surname = '" + surname + "' ", conn);
			rspupils = sql.ExecuteReader();
			if (numRows > 0)
			{
				if (numRows > 1)
				{
					while (rspupils.Read())
					{
						Console.WriteLine("Pupil " + count);
						pupils[count].id = (int)rspupils["id"];
						pupils[count].forename = (string)rspupils["forename"];
						pupils[count].surname = (string)rspupils["surname"];
						pupils[count].house = (string)rspupils["house"];
						pupils[count].age = (int)rspupils["age"];
						Console.WriteLine("Name: " + pupils[count].forename + " " + pupils[count].surname);
						Console.WriteLine();
						count += 1;
					}
					Console.WriteLine("Select pupil");
					choice = Console.ReadLine();
					count = int.Parse(choice);
				}
				else
				{
					rspupils.Read();
					pupils[count].id = (int)rspupils["id"];
					pupils[count].forename = (string)rspupils["forename"];
					pupils[count].surname = (string)rspupils["surname"];
					pupils[count].house = (string)rspupils["house"];
					pupils[count].age = (int)rspupils["age"];
				}
				return true;

			}
			else
			{
				Console.WriteLine("No pupil with that name found");
				Console.ReadKey();
				return false;
			}
		}
		//This findclassesForPupil function is used in viewpupil
		public static bool findclassesForPupil(int pupilId, ref Classes[] tempclass, ref int count)
		{
			//This function finds all the classes for a particular pupil
			//Returns true if classes found, otherwise returns false
			//If class(es) found they will be put into tempclass struture that is passed by reference
			SQLiteCommand sql = new SQLiteCommand("SELECT coursename, teachersID FROM classes, enrolment WHERE enrolment.pupilsId = '" + pupilId + "' AND classes.id = enrolment.classesId", conn);
			SQLiteDataReader rsclass;
			rsclass = sql.ExecuteReader();
			if (rsclass.HasRows)
			{

				while (rsclass.Read())
				{
					count += 1;
					tempclass[count].name = (string)rsclass["coursename"];

					SQLiteCommand sql2 = new SQLiteCommand("SELECT teacherName FROM teachers WHERE ID = '" + (long)rsclass["teachersID"] + "'", conn);
					SQLiteDataReader rsteacher;
					rsteacher = sql2.ExecuteReader();
					rsteacher.Read();

					tempclass[count].teacher = (string)rsteacher["teacherName"];
				}
				return true;
			}
			else
			{
				return false;
			}


		}
		//The following four subs have been coded. Use them to help you with your code
		public static void viewpupil()
		{
			string surname;
			int count = 0;
			pupil[] pupils = new pupil[11];
			Classes[] tempclass = new Classes[11];
			int numofclasses = -1;
			bool found = false;
			Console.WriteLine("View Pupil Information");
			Console.WriteLine();
			Console.WriteLine("Enter pupil surname:");
			surname = Console.ReadLine();
			found = findpupil(ref pupils, surname, ref count);
			if (found)
			{

				Console.WriteLine();
				Console.WriteLine("Name:  " + pupils[count].forename + " " + pupils[count].surname);
				Console.WriteLine("House: " + pupils[count].house);
				Console.WriteLine("Age:   " + pupils[count].age);
				Console.WriteLine();
				if (findclassesForPupil(pupils[count].id, ref tempclass, ref numofclasses))
				{
					for (int i = 0; i < numofclasses + 1; i++)
					{
						Console.WriteLine("Class name:   " + tempclass[i].name);
						Console.WriteLine("Teacher name: " + tempclass[i].teacher);
						Console.WriteLine();
					}
				}
				else
				{
					Console.WriteLine("This pupil does not have any classes");
				}
				Console.ReadKey();
			}
		}
		public static void addpupil()
		{
			string surname, forename, house;
			int age;
			Console.WriteLine("Add New Pupil");
			Console.WriteLine();
			Console.WriteLine("Enter pupil surname:");
			surname = Console.ReadLine();
			Console.WriteLine("Enter pupil forename:");
			forename = Console.ReadLine();
			Console.WriteLine("Enter pupil age:");
			age = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter pupil house:");
			house = Console.ReadLine();
			SQLiteCommand sql = new SQLiteCommand("INSERT INTO pupils(forename,surname,house,age) VALUES ('" + forename + "', '" + surname + "', '" + house + "', '" + age + "')", conn);
			sql.ExecuteNonQuery();
			Console.WriteLine();
			Console.WriteLine("New pupil " + forename + " " + surname + " added.");
			Console.WriteLine("Press enter to return to menu");
			Console.ReadKey();
		}
		public static void deletepupil()
		{
			string surname, choice;
			pupil[] pupils = new pupil[11];
			bool found;
			int id, count;
			id = 0;
			SQLiteDataReader rsid;
			count = 0;
			Console.WriteLine("Delete Pupil");
			Console.WriteLine();
			Console.WriteLine("The pupil and any enrolments associated with this pupil will be deleted.");
			Console.WriteLine();
			Console.WriteLine("Enter pupil's surname:");
			surname = Console.ReadLine();
			Console.WriteLine();
			found = findpupil(ref pupils, surname, ref count);
			if (found)
			{
				Console.WriteLine("Are you sure you want to delete " + pupils[count].forename + " " + pupils[count].surname + "? (Y/N)");
				choice = Console.ReadLine().ToUpper();
				if (choice == "Y")
				{
					SQLiteCommand sqlid = new SQLiteCommand("SELECT id FROM pupils WHERE surname = '" + surname + "'", conn);
					rsid = sqlid.ExecuteReader();
					if (rsid.Read())
					{
						id = (int)rsid["id"];
					}

					SQLiteCommand sqldeleteenrolment = new SQLiteCommand("DELETE FROM enrolment WHERE pupilsId = '" + id + "'", conn);
					sqldeleteenrolment.ExecuteNonQuery();
					SQLiteCommand sqldeleteclass = new SQLiteCommand("DELETE FROM pupils WHERE id = '" + id + "'", conn);
					sqldeleteclass.ExecuteNonQuery();
					Console.WriteLine();
					Console.WriteLine("Pupil " + pupils[count].forename + " " + pupils[count].surname + " has been deleted.");
				}
			}

			Console.WriteLine("Press enter to return to menu");
			Console.ReadKey();
		}
		public static void pupilsall()
		{
			SQLiteDataReader rspupils;
			Console.WriteLine("List of all pupils");
			Console.WriteLine();
			SQLiteCommand sql = new SQLiteCommand("select * from pupils order by house", conn);
			rspupils = sql.ExecuteReader();
			Console.WriteLine();
			while (rspupils.Read())
			{
				Console.WriteLine(rspupils["house"] + " " + rspupils["forename"] + " " + rspupils["surname"] + " " + rspupils["age"]);
			}

			Console.WriteLine();
			Console.WriteLine("Press enter to return to menu");
			Console.ReadKey();
		}
		public static void viewclass()
		{
			//In this sub the user enters in a class name.  
			//If the class exists then the teacher of the class is displayed  (SQL required for this)
			//also a list of the pupils in the class is displayed (SQL required for this)
			Console.ReadKey();

		}
		public static void addclass()
		{
			//In this sub the user enters in a new class  
			//The user enters a class name and a teacher which is put into the database (SQL required for this)
			Console.ReadKey();
		}
		public static void deleteclass()
		{
			//In this sub the user deltes a class  
			//The user enters a class name 
			//Firstly the id of the class will need to be retieved(SQL required for this)
			//Then any enrolments with this class need to be deleted (SQL required for this)
			//Finally the class needs to be deleted from the classes table (SQL required for this)
			Console.ReadKey();
		}
		public static void viewallclasses()
		{
			//This sub displays all the classes and the teachers (SQL required for this)
			Console.ReadKey();
		}
		public static void enrolpupil()
		{
			//This sub enrols a particular pupil onto a particular class
			//User enters a pupil surname. Use the findpupil function here to help choose the pupil as maybe more than one with same surname
			//Then user enters class name. Need to get class details from database (SQL required for this)
			//Then insert a new enrolment into the enrolment table using the pupil id and class id found before (SQL required for this)
			Console.ReadKey();
		}
		public static void removeenrolment()
		{
			//This sub removes a pupil from a class
			//User enters a class. Need to get class details from database (SQL required for this)
			//User enters a pupil surname. Use the findpupil function here to help choose the pupil as maybe more than one with same surname
			//Then delete the enrolment from the enrolment table using the pupil id and class id found before (SQL required for this)
			Console.ReadKey();
		}
		//Menus all coded for you
		public static void mainmenu()
		{
			Console.WriteLine("Welcome to HogFocus");
			Console.WriteLine();
			Console.WriteLine("1. Pupil information");
			Console.WriteLine("2. Class information");
			Console.WriteLine("3. Enroling and removing pupils from classes");
			Console.WriteLine();
			Console.WriteLine("9. Exit");
			Console.WriteLine();
		}
		public static void pupilmenu()
		{
			Console.WriteLine("HogFocus - Pupil Section");
			Console.WriteLine();
			Console.WriteLine("1. View a pupil's information");
			Console.WriteLine("2. Add a new pupil");
			Console.WriteLine("3. Delete a pupil");
			Console.WriteLine("4. View all pupils");
			Console.WriteLine();
			Console.WriteLine("9. Return to Main Menu");
			Console.WriteLine();
		}
		public static void classmenu()
		{
			Console.WriteLine("HogFocus - Class Section");
			Console.WriteLine();
			Console.WriteLine("1. View class information");
			Console.WriteLine("2. Add a new class");
			Console.WriteLine("3. Delete a class");
			Console.WriteLine("4. View a list of all classes");
			Console.WriteLine();
			Console.WriteLine("9. Return to Main Menu");
			Console.WriteLine();
		}
		public static void enrolmenu()
		{
			Console.WriteLine("HogStudio - Enrolment Section");
			Console.WriteLine();
			Console.WriteLine("1. Enrol a pupil onto a class");
			Console.WriteLine("2. Remove a pupil from a class");
			Console.WriteLine();
			Console.WriteLine("9. Return to Main Menu");
			Console.WriteLine();
		}
		public static void pupilsection()
		{
			int Choice = -1;
			do
			{	 
				pupilmenu();
				do
				{
					Console.Write("\rPlease enter your choice: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); break; }
					Console.WriteLine("\nPlease input one of the numbers shown.");
					Console.CursorTop -= 2;
				} while (!menuOptions.Contains(Choice));
				switch (Choice)
				{
					case 1:
						viewpupil();
						break;
					case 2:
						addpupil();
						break;
					case 3:
						deletepupil();
						break;
					case 4:
						pupilsall();
						break;
				}
			} while (Choice != 9);
		}
		public static void classsection()
		{
			int Choice = -1;
			do
			{	
				classmenu();
				do
				{
					Console.Write("\rPlease enter your choice: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); break; }
					Console.WriteLine("\nPlease input one of the numbers shown.");
					Console.CursorTop -= 2;
				} while (!menuOptions.Contains(Choice));
				switch (Choice)
				{
					case 1:
						viewclass();
						break;
					case 2:
						addclass();
						break;
					case 3:
						deleteclass();
						break;
					case 4:
						viewallclasses();
						break;
				}
			} while (Choice != 9);
		}
		public static void enrolsection()
		{
			int Choice = -1;
			do
			{	 
				enrolmenu();
				do
				{
					Console.Write("\rPlease enter your choice: ");
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); break; }
					Console.WriteLine("\nPlease input one of the numbers shown.");
					Console.CursorTop -= 2;
				} while (!menuOptions.Contains(Choice) && Choice != 3 && Choice != 4);
				switch (Choice)
				{
					case 1:
						enrolpupil();
						break;
					case 2:
						removeenrolment();
						break;
				}
				break;
			} while (Choice != 9);
		}
	}
}