//Skeleton Program for the February Assessment examination
//this code should be used in conjunction with the Preliminary Material
//written by the AQA Programmer Team
//developed in a Visual Studio Community programming environment

//Version Number 1.0

using System;
using System.IO;

internal class Warships
{
	public struct ShipType
	{
		public string Name;
		public int Size;
	}
	
	public class User
	{
		public string Name { get; set; }
		public int Guesses { get; set; }

	}
	public static User user = new User();
	const string TrainingGame = "Training.txt";

	private static void GetRowColumn(ref int Row, ref int Column)
	{
		Console.WriteLine();
		while (Column < 0 || Column > 9)
		{
			Console.Write("\rPlease enter column: ");
			var UserInput = Console.ReadKey();
			if (char.IsDigit(UserInput.KeyChar)) { Column = int.Parse(UserInput.KeyChar.ToString()); }
		}
		while (Row < 0 || Row > 9)
		{
			Console.Write("\rPlease enter row: ");
			var UserInput = Console.ReadKey();
			if (char.IsDigit(UserInput.KeyChar)) { Row = int.Parse(UserInput.KeyChar.ToString()); }
		}
		Console.WriteLine();
	}

	private static void MakePlayerMove(ref char[,] Board, ref ShipType[] Ships)
	{
		int Row = 0;
		int Column = 0;
		GetRowColumn(ref Row, ref Column); 
		if (Board[Row, Column] == 'm' || Board[Row, Column] == 'h')
		{
			Console.BackgroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("Sorry, you have already shot at the square (" + Column + "," + Row + "). Please try again.");
			Console.ResetColor();
			user.Guesses -= 1;
		}
		else if (Board[Row, Column] == '-')
		{
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.WriteLine("Sorry, (" + Column + "," + Row + ") is a miss.");
			Console.ResetColor();
			Board[Row, Column] = 'm';
		}
		else
		{
			Console.BackgroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Hit at (" + Column + "," + Row + ").");
			Console.ResetColor();
			Board[Row, Column] = 'h';
		}
		user.Guesses += 1;
	}

	private static void SetUpBoard(ref char[,] Board)
	{
		for (int Row = 0; Row < 10; Row++)
		{
			for (int Column = 0; Column < 10; Column++)
			{
				Board[Row, Column] = '-';
			}
		}
	}

	private static void LoadGame(string TrainingGame, ref char[,] Board)
	{
		string Line = "";
		using (StreamReader BoardFile = new StreamReader(TrainingGame))
		{
			for (int Row = 0; Row < 10; Row++)
			{
				Line = BoardFile.ReadLine();
				for (int Column = 0; Column < 10; Column++)
				{
					Board[Row, Column] = Line[Column];
				}
			}
		}
	}

	private static void PlaceRandomShips(ref char[,] Board, ShipType[] Ships)
	{
		Random RandomNumber = new Random();
		bool Valid;
		char Orientation = ' ';
		int Row = 0;
		int Column = 0;
		int HorV = 0;
		foreach (var Ship in Ships)
		{
			Valid = false;
			while (Valid == false)
			{
				Row = RandomNumber.Next(0, 10);
				Column = RandomNumber.Next(0, 10);
				HorV = RandomNumber.Next(0, 2);
				if (HorV == 0)
				{
					Orientation = 'v';
				}
				else
				{
					Orientation = 'h';
				}
				Valid = ValidateBoatPosition(Board, Ship, Row, Column, Orientation);
			}
			Console.Write("Computer placing the ");
			Console.ForegroundColor = ConsoleColor.Red; Console.Write(Ship.Name);
			Console.ForegroundColor = ConsoleColor.Gray; Console.Write(", which takes up ");
			Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(Ship.Size);
			Console.ForegroundColor = ConsoleColor.Gray; Console.WriteLine(" spaces on the board.");
			PlaceShip(ref Board, Ship, Row, Column, Orientation);
		}
	}

	private static void PlaceShip(ref char[,] Board, ShipType Ship, int Row, int Column, char Orientation)
	{
		if (Orientation == 'v')
		{
			for (int Scan = 0; Scan < Ship.Size; Scan++)
			{
				Board[Row + Scan, Column] = Ship.Name[0];
			}
		}
		else if (Orientation == 'h')
		{
			for (int Scan = 0; Scan < Ship.Size; Scan++)
			{
				Board[Row, Column + Scan] = Ship.Name[0];
			}
		}
	}

	private static bool ValidateBoatPosition(char[,] Board, ShipType Ship, int Row, int Column, char Orientation)
	{
		if (Orientation == 'v' && Row + Ship.Size > 10)
		{
			return false;
		}
		else if (Orientation == 'h' && Column + Ship.Size > 10)
		{
			return false;
		}
		else
		{
			if (Orientation == 'v')
			{
				for (int Scan = 0; Scan < Ship.Size; Scan++)
				{
					if (Board[Row + Scan, Column] != '-')
					{
						return false;
					}
				}
			}
			else if (Orientation == 'h')
			{
				for (int Scan = 0; Scan < Ship.Size; Scan++)
				{
					if (Board[Row, Column + Scan] != '-')
					{
						return false;
					}
				}
			}
		}
		return true;
	}

	private static bool CheckWin(char[,] Board)
	{
		for (int Row = 0; Row < 10; Row++)
		{
			for (int Column = 0; Column < 10; Column++)
			{
				if (Board[Row, Column] == 'A' || Board[Row, Column] == 'B' || Board[Row, Column] == 'S' || Board[Row, Column] == 'D' || Board[Row, Column] == 'P')
				{
					return false;
				}
			}
		}
		return true;
	}

	private static void PrintBoard(char[,] Board)
	{
		Console.WriteLine("The board looks like this: ");
		Console.WriteLine();
		Console.Write(" ");
		for (int Column = 0; Column < 10; Column++)
		{
			Console.Write(" " + Column + "  ");
		}
		Console.WriteLine();
		for (int Row = 0; Row < 10; Row++)
		{
			Console.Write(Row + " ");
			for (int Column = 0; Column < 10; Column++)
			{
				if (Board[Row, Column] == '-')
				{
					Console.Write(" ");
				}
				else if (Board[Row, Column] == 'A' || Board[Row, Column] == 'B' || Board[Row, Column] == 'S' || Board[Row, Column] == 'D' || Board[Row, Column] == 'P')
				{
					Console.Write(" ");
				}
				else
				{
					Console.Write(Board[Row, Column]);
				}
				if (Column != 9)
				{
					Console.Write(" | ");
				}
			}
			Console.WriteLine();
		}
	}

	private static void AskName()
	{
		Console.Write("Input your name: ");
		user.Name = Console.ReadLine();
		Console.Clear();
	}

	private static void DisplayMenu()
	{
		Console.ForegroundColor = ConsoleColor.White;
		Console.WriteLine($"Welcome {user.Name}, to AQA WARSHIPS!");
		Console.WriteLine(""); Console.ResetColor();
		Console.WriteLine("MAIN MENU");
		Console.WriteLine("");
		Console.WriteLine("1. Start new game");
		Console.WriteLine("2. Load training game");
		Console.WriteLine("9. Quit");
		Console.WriteLine();
	}

	private static int GetMainMenuChoice()
	{
		int Choice = -1;
		do
		{
			Console.Write("\rPlease enter your choice: ");
			var UserInput = Console.ReadKey();
			if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); }
			Console.WriteLine("\nPlease input one of the numbers shown.");
			Console.CursorTop -= 2;
		} while (Choice != 1 && Choice != 2 && Choice != 9);
		Console.Clear(); return Choice;
	}

	private static void PlayGame(ref char[,] Board, ref ShipType[] Ships)
	{
		bool GameWon = false;
		while (GameWon == false)
		{
			PrintBoard(Board);
			MakePlayerMove(ref Board, ref Ships);
			GameWon = CheckWin(Board);
			if (GameWon == true)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine($"All ships sunk! Well done {user.Name}. It took you {user.Guesses} guesses.");
				Console.ResetColor(); Console.Clear();
			}
		}
	}

	private static void SetUpShips(ref ShipType[] Ships)
	{
		Ships[0].Name = "Aircraft Carrier";
		Ships[0].Size = 5;
		Ships[1].Name = "Battleship";
		Ships[1].Size = 4;
		Ships[2].Name = "Submarine";
		Ships[2].Size = 3;
		Ships[3].Name = "Destroyer";
		Ships[3].Size = 3;
		Ships[4].Name = "Patrol Boat";
		Ships[4].Size = 2;
	}

	static void Main(string[] args)
	{
		ShipType[] Ships = new ShipType[5];
		char[,] Board = new char[10, 10];
		int MenuOption = -1;
		while (MenuOption != 9)
		{
			SetUpBoard(ref Board);
			SetUpShips(ref Ships);
			AskName();
			DisplayMenu();
			MenuOption = GetMainMenuChoice();
			if (MenuOption == 1)
			{
				PlaceRandomShips(ref Board, Ships);
				PlayGame(ref Board, ref Ships);
			}
			if (MenuOption == 2)
			{
				LoadGame(TrainingGame, ref Board);
				PlayGame(ref Board, ref Ships);
			}
		}
	}
}