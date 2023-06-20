// Amended code for the ***REMOVED*** Computer Science CAP2 examination
// this code should be used in conjunction with the Preliminary Material
// developed using Visual Studio

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace A130
{
	internal class AmendedCAP2Code
	{
		
		class QueueOfTiles
		{
			protected List<string> Contents = new List<string>();
			protected int Rear;
			protected int MaxSize;
			Random Rnd = new Random();

			public QueueOfTiles(int MaxSize)
			{
				this.MaxSize = MaxSize;
				this.Rear = -1;
				for (int Count = 0; Count < this.MaxSize; Count++)
				{
					Contents.Add("");
					this.Add();
				}
			}

			public bool IsEmpty()
			{
				if (this.Rear == -1)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			public string Remove()
			{
				string Item = "";
				if (IsEmpty())
				{
					return "";
				}
				else
				{
					Item = Contents[0];
					for (int Count = 1; Count < Rear + 1; Count++)
					{
						Contents[Count - 1] = Contents[Count];
					}
					Contents[Rear] = "";
					Rear--;
					return Item;
				}
			}

			public void Add()
			{
				int RandNo = 0;
				if (Rear < MaxSize - 1)
				{
					RandNo = Rnd.Next(0, 26);
					Rear++;
					Contents[Rear] = Convert.ToChar(65 + RandNo).ToString();
				}
			}

			public void Show()
			{
				if (Rear != -1)
				{
					Console.WriteLine();
					Console.Write("The contents of the queue are: ");
					foreach (var item in Contents)
					{
						Console.Write(item);
					}
					Console.WriteLine();
				}
			}
		}

		static void Main(string[] args)
		{
			HashSet<String> AllowedWords = new HashSet<string>();
			Dictionary<Char, int> TileDictionary = new Dictionary<char, int>();
			int MaxHandSize = 20;
			int MaxTilesPlayed = 50;
			int NoOfEndOfTurnTiles = 3;
			int StartHandSize = 15;
			string Choice = "";
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("+ Welcome to the WORDS WITH AQA game +");
			Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
			Console.WriteLine("");
			Console.WriteLine("");
			LoadAllowedWords(ref AllowedWords);
			CreateTileDictionary(ref TileDictionary);
			while (Choice != "9")
			{
				DisplayMenu();
				Console.Write("Enter your choice: ");
				Choice = Console.ReadLine();
				if (Choice == "1")
				{
					PlayGame(AllowedWords, TileDictionary, true, StartHandSize, MaxHandSize, MaxTilesPlayed, NoOfEndOfTurnTiles);
				}
				else if (Choice == "2")
				{
					PlayGame(AllowedWords, TileDictionary, false, 15, MaxHandSize, MaxTilesPlayed, NoOfEndOfTurnTiles);
				}
			}
		}

		private static void CreateTileDictionary(ref Dictionary<char, int> TileDictionary)
		{
			int[] Value1 = { 0, 4, 8, 13, 14, 17, 18, 19 };
			int[] Value2 = { 1, 2, 3, 6, 11, 12, 15, 20 };
			int[] Value3 = { 5, 7, 10, 21, 22, 24 };
			for (int Count = 0; Count < 26; Count++)
			{
				if (Array.IndexOf(Value1, Count) > -1)
				{
					TileDictionary.Add((char)(65 + Count), 1);
				}
				else if (Array.IndexOf(Value2, Count) > -1)
				{
					TileDictionary.Add((char)(65 + Count), 2);
				}
				else if (Array.IndexOf(Value3, Count) > -1)
				{
					TileDictionary.Add((char)(65 + Count), 3);
				}
				else
				{
					TileDictionary.Add((char)(65 + Count), 5);
				}
			}
		}

		private static void DisplayTileValues(Dictionary<char, int> TileDictionary, HashSet<string> AllowedWords)
		{
			Console.WriteLine();
			Console.WriteLine("TILE VALUES");
			Console.WriteLine();
			foreach (var Tile in TileDictionary)
			{
				Console.WriteLine("Points for " + Tile.Key + ": " + Tile.Value);
			}
			Console.WriteLine();
		}

		private static string GetStartingHand(QueueOfTiles TileQueue, int StartHandSize)
		{
			string Hand = "";
			for (int Count = 0; Count < StartHandSize; Count++)
			{
				Hand = Hand + TileQueue.Remove();
				TileQueue.Add();
			}
			return Hand;
		}

		private static void LoadAllowedWords(ref HashSet<string> AllowedWords)
		{
			int GetChoice(in int[] options)
			{
				int choice = 0;
				do
				{
					Console.Write("\rPlease enter your choice:  "); Console.CursorLeft--;
					var UserInput = Console.ReadKey();
					if (char.IsDigit(UserInput.KeyChar)) { choice = int.Parse(UserInput.KeyChar.ToString()); }
					Console.WriteLine();
				} while (!options.Contains(choice));
				return choice;
			}

			Console.WriteLine("Enter '1' to use the default word list or '2' to enter your own list");
			string filePath = null; StreamReader sr = null;
			switch (GetChoice(new int[] { 1, 2 }))
			{
			case 1:
			@Default:
				filePath = Directory.GetCurrentDirectory();
				filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\..\..\Lessons\L176"));
				Directory.SetCurrentDirectory(filePath);
				sr = new StreamReader(filePath); // broken code - access denied
				break;
			case 2:
				Console.WriteLine("Do you want to use a local file: '1' | or a link to a .txt file: '2'");
				switch (GetChoice(new int[] { 1, 2 }))
				{
				case 1:
					Console.WriteLine("Custom: '1' | Runtime: '2'");
					switch (GetChoice(new int[] { 1, 2 }))
					{
					case 1:
					Custom:
						Console.Write("Enter the path to the file containing the list of words (include file name): ");
						do
						{
							string input = Console.ReadLine();
							if (input == "default")	goto Default;
							filePath = Path.GetFullPath(@input);
							if (File.Exists(filePath))
							{
								Console.WriteLine("File loaded.");
								break;
							}						
							Console.WriteLine("If your file can't be loaded, you can type 'default' to use the default word list.");
						} while (!File.Exists(filePath));
						break; 
					case 2:
						Console.WriteLine("Input your file name: ");
						do
						{
							filePath = Console.ReadLine();
							if (filePath == "default") goto Default;
							else if (filePath == "custom") goto Custom;
							if (File.Exists(filePath)) break;
							Console.WriteLine("File not found. Please try again.");
							Console.WriteLine("If your file can't be loaded, you can type 'default' to use the default word list or 'custom' to use a custom file path. ");
						} while (!File.Exists(filePath));
						break;
					}
					sr = new StreamReader(filePath);
				break;
				case 2:
					Console.Write("Enter the link to the file containing the list of words: ");
					WebRequest request = WebRequest.Create(Console.ReadLine());
					request.Method = WebRequestMethods.Http.Get;
					request.ContentType = "text/plain";
					HttpWebResponse response = (HttpWebResponse)request.GetResponse();
					sr = new StreamReader(response.GetResponseStream());
					break;
				}
				break;
			}

			using (sr)
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					AllowedWords.Add(line);
				}
			}
		}
		private static bool CheckWordIsInTiles(string Word, string PlayerTiles)
		{
			bool InTiles = true;
			string CopyOfTiles = PlayerTiles;
			for (int Count = 0; Count < Word.Length; Count++)
			{
				if (CopyOfTiles.Contains(Word[Count]))
				{
					CopyOfTiles = CopyOfTiles.Remove(CopyOfTiles.IndexOf(Word[Count].ToString()), 1);
				}
				else
				{
					InTiles = false;
				}
			}
			return InTiles;
		}

		private static bool CheckWordIsValid(string Word, HashSet<string> AllowedWords)
		{
			bool ValidWord = false;
			if (AllowedWords.Contains(Word)) ValidWord = true;
			return ValidWord;
		}

		private static void AddEndOfTurnTiles(ref QueueOfTiles TileQueue, ref string PlayerTiles, string NewTileChoice, string Choice)
		{
			int NoOfEndOfTurnTiles = 0;
			if (NewTileChoice == "1")
			{
				NoOfEndOfTurnTiles = Choice.Length;
			}
			else if (NewTileChoice == "2")
			{
				NoOfEndOfTurnTiles = 3;
			}
			else
			{
				NoOfEndOfTurnTiles = Choice.Length + 3;
			}
			for (int Count = 0; Count < NoOfEndOfTurnTiles; Count++)
			{
				PlayerTiles = PlayerTiles + TileQueue.Remove();
				TileQueue.Add();
			}
		}

		private static void FillHandWithTiles(ref QueueOfTiles TileQueue, ref string PlayerTiles, int MaxHandSize)
		{
			while (PlayerTiles.Length <= MaxHandSize)
			{
				PlayerTiles = PlayerTiles + TileQueue.Remove();
				TileQueue.Add();
			}
		}

		private static int GetScoreForWord(string Word, Dictionary<char, int> TileDictionary)
		{
			int Score = 0;
			for (int Count = 0; Count < Word.Length; Count++)
			{
				Score = Score + TileDictionary[Word[Count]];
			}
			if (Word.Length > 7)
			{
				Score = Score + 20;
			}
			else if (Word.Length > 5)
			{
				Score = Score + 5;
			}
			return Score;
		}

		private static void UpdateAfterAllowedWord(string Word, ref string PlayerTiles, ref int PlayerScore, ref int PlayerTilesPlayed, Dictionary<char, int> TileDictionary, HashSet<string> AllowedWords)
		{
			PlayerTilesPlayed = PlayerTilesPlayed + Word.Length;
			foreach (var Letter in Word)
			{
				PlayerTiles = PlayerTiles.Remove(PlayerTiles.IndexOf(Letter), 1);
			}
			PlayerScore = PlayerScore + GetScoreForWord(Word, TileDictionary);
		}

		private static void UpdateScoreWithPenalty(ref int PlayerScore, string PlayerTiles, Dictionary<char, int> tileDictionary)
		{
			for (int Count = 0; Count < PlayerTiles.Length; Count++)
			{
				PlayerScore = PlayerScore - tileDictionary[PlayerTiles[Count]];
			}
		}

		private static string GetChoice()
		{
			string Choice;
			Console.WriteLine();
			Console.WriteLine("Either:");
			Console.WriteLine("     enter the word you would like to play OR");
			Console.WriteLine("     press 1 to display the letter values OR");
			Console.WriteLine("     press 4 to view the tile queue OR");
			Console.WriteLine("     press 7 to view your tiles again OR");
			Console.WriteLine("     press 0 to fill hand and stop the game.");
			Console.Write("> ");
			Choice = Console.ReadLine();
			Console.WriteLine();
			Choice = Choice.ToUpper();
			return Choice;
		}

		private static string GetNewTileChoice()
		{
			string NewTileChoice = "";
			string[] TileChoice = { "1", "2", "3", "4" };
			while (Array.IndexOf(TileChoice, NewTileChoice) == -1)
			{
				Console.WriteLine("Do you want to:");
				Console.WriteLine("     replace the tiles you used (1) OR");
				Console.WriteLine("     get three extra tiles (2) OR");
				Console.WriteLine("     replace the tiles you used and get three extra tiles (3) OR");
				Console.WriteLine("     get no new tiles (4)?");
				Console.Write("> ");
				NewTileChoice = Console.ReadLine();
			}
			return NewTileChoice; ;
		}

		private static void DisplayTilesInHand(string PlayerTiles)
		{
			Console.WriteLine();
			Console.WriteLine("Your current hand:" + PlayerTiles);
		}


		private static void HaveTurn(string PlayerName, ref string PlayerTiles, ref int PlayerTilesPlayed, ref int PlayerScore, Dictionary<char, int> TileDictionary, ref QueueOfTiles TileQueue, HashSet<string> AllowedWords, int MaxHandSize, int NoOfEndOfTurnTiles)
		{
			Console.WriteLine();
			Console.WriteLine(PlayerName + " it is your turn.");
			DisplayTilesInHand(PlayerTiles);
			string NewTileChoice = "2";
			bool ValidChoice = false;
			bool ValidWord = false;
			string Choice = "";
			while (!ValidChoice)
			{
				Choice = GetChoice();
				if (Choice == "1")
				{
					DisplayTileValues(TileDictionary, AllowedWords);
				}
				else if (Choice == "4")
				{
					TileQueue.Show();
				}
				else if (Choice == "7")
				{
					DisplayTilesInHand(PlayerTiles);
				}
				else if (Choice == "0")
				{
					ValidChoice = true;
					FillHandWithTiles(ref TileQueue, ref PlayerTiles, MaxHandSize);
				}
				else
				{
					ValidChoice = true;
					if (Choice.Length == 0)
					{
						ValidWord = false;
					}
					else
					{
						ValidWord = CheckWordIsInTiles(Choice, PlayerTiles);
					}
					if (ValidWord)
					{
						ValidWord = CheckWordIsValid(Choice, AllowedWords);
						if (ValidWord)
						{
							Console.WriteLine();
							Console.WriteLine("Valid word");
							Console.WriteLine();
							UpdateAfterAllowedWord(Choice, ref PlayerTiles, ref PlayerScore, ref PlayerTilesPlayed, TileDictionary, AllowedWords);
							NewTileChoice = GetNewTileChoice();
						}
					}
					if (!ValidWord)
					{
						Console.WriteLine();
						Console.WriteLine("Not a valid attempt, you lose your turn.");
						Console.WriteLine();
					}
					if (NewTileChoice != "4")
					{
						AddEndOfTurnTiles(ref TileQueue, ref PlayerTiles, NewTileChoice, Choice);
					}
					Console.WriteLine();
					Console.WriteLine("Your word was:" + Choice);
					Console.WriteLine("Your new score is:" + PlayerScore);
					Console.WriteLine("You have played " + PlayerTilesPlayed + " tiles so far in this game.");
				}
			}
		}

		private static void DisplayWinner(int PlayerOneScore, int PlayerTwoScore)
		{
			Console.WriteLine();
			Console.WriteLine("**** GAME OVER! ****");
			Console.WriteLine();
			Console.WriteLine("Player One your score is " + PlayerOneScore);
			Console.WriteLine("Player Two your score is " + PlayerTwoScore);
			if (PlayerOneScore > PlayerTwoScore)
			{
				Console.WriteLine("Player One wins!");
			}
			else if (PlayerTwoScore > PlayerOneScore)
			{
				Console.WriteLine("Player Two wins!");
			}
			else
			{
				Console.WriteLine("It is a draw!");
			}
			Console.WriteLine();
		}

		private static void PlayGame(HashSet<string> AllowedWords, Dictionary<char, int> TileDictionary, bool RandomStart, int StartHandSize, int MaxHandSize, int MaxTilesPlayed, int NoOfEndOfTurnTiles)
		{
			int PlayerOneScore = 50;
			int PlayerTwoScore = 50;
			int PlayerOneTilesPlayed = 0;
			int PlayerTwoTilesPlayed = 0;
			string PlayerOneTiles = "";
			string PlayerTwoTiles = "";
			QueueOfTiles TileQueue = new QueueOfTiles(20);
			if (RandomStart)
			{
				PlayerOneTiles = GetStartingHand(TileQueue, StartHandSize);
				PlayerTwoTiles = GetStartingHand(TileQueue, StartHandSize);
			}
			else
			{
				PlayerOneTiles = "BTAHANDENONSARJ";
				PlayerTwoTiles = "CELZXIOTNESMUAA";
			}
			while (PlayerOneTilesPlayed <= MaxTilesPlayed && PlayerTwoTilesPlayed <= MaxTilesPlayed && PlayerOneTiles.Length < MaxHandSize && PlayerTwoTiles.Length < MaxHandSize)
			{
				HaveTurn("Player One", ref PlayerOneTiles, ref PlayerOneTilesPlayed, ref PlayerOneScore, TileDictionary, ref TileQueue, AllowedWords, MaxHandSize, NoOfEndOfTurnTiles);
				Console.WriteLine();
				Console.WriteLine("Press Enter to continue");
				Console.ReadLine();
				Console.WriteLine();
				HaveTurn("Player Two", ref PlayerTwoTiles, ref PlayerTwoTilesPlayed, ref PlayerTwoScore, TileDictionary, ref TileQueue, AllowedWords, MaxHandSize, NoOfEndOfTurnTiles);
			}
			UpdateScoreWithPenalty(ref PlayerOneScore, PlayerOneTiles, TileDictionary);
			UpdateScoreWithPenalty(ref PlayerTwoScore, PlayerTwoTiles, TileDictionary);
			DisplayWinner(PlayerOneScore, PlayerTwoScore);
		}

		private static void DisplayMenu()
		{
			Console.WriteLine();
			Console.WriteLine("=========");
			Console.WriteLine("MAIN MENU");
			Console.WriteLine("=========");
			Console.WriteLine();
			Console.WriteLine("1. Play game with random start hand");
			Console.WriteLine("2. Play game with training start hand");
			Console.WriteLine("9. Quit");
			Console.WriteLine();
		}
		
	}
}
