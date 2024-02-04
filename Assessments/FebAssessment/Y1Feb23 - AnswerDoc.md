<table>
  <tr>
   <td><strong>Centre number</strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong>Candidate number</strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
   <td><strong></strong>
   </td>
  </tr>
  <tr>
   <td><strong>Surname</strong>
   </td>
   <td colspan="10"><strong>Oks</strong>
   </td>
  </tr>
  <tr>
   <td><strong>Forename(s)</strong>
   </td>
   <td colspan="10"><strong>Ervin</strong>
   </td>
  </tr>
  <tr>
   <td><strong>Candidate signature</strong>
   </td>
   <td colspan="10" >
   </td>
  </tr>
  <tr>
   <td><strong>Programming Language</strong>
   </td>
   <td colspan="10" ><strong>C# (7517/1A) </strong>
   </td>
  </tr>
</table>


# COMPUTER SCIENCE
## Paper 1 – February Assessment
### February 2023	    
### Time allowed: 1 hour 5 minutes

#### Instructions
- This is the Electronic Answer Document (EAD).  Answer **all** questions by entering your answers into this document on screen.  
- Before the examination begins, type the information needed in the boxes **at the top of this page**.

#### Warning 
- It may not be possible to credit an answer if your:
    - details are not printed on every page as instructed above
    - screen captures are not legible to the Examiner.
    
Answer **all** questions.  

## Section C
<table>
  <tr>
   <td colspan="5" ><strong>Question 1</strong>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" >“Orientation” <pre lang="csharp">char Orientation = ' '</pre>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" >“SetUpBoard” <pre lang="csharp">private static void SetUpBoard(ref char[,] Board)</pre>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td colspan="2" >“ValidateBoatPosition” <pre lang="csharp">private static bool ValidateBoatPosition(char[,] Board, ShipType Ship, int Row, int Column, char Orientation)</pre>
   </td>
  </tr>
</table>

<table>
  <tr>
   <td colspan="5" ><strong>Question 2</strong>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" >An advantage of using a const is making it like a read-only variable, where it’s defined once and doesn’t change so it can then be read everywhere throughout the code.
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" >The for loop scans through each coordinate in place of where the ship goes, and to see if there’s a ‘-’ there, meaning an empty space.
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td colspan="2" >The first structure of the subroutine is to check if it goes entirely off of the board (like if it’s at the coordinate on the very end, and going horizontally it’ll be off of the board)
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>4</strong>
   </td>
   <td colspan="2" >Exception handling is a term for saying “dealing with a possible error”, such as in the <code>GetRowColumn</code> subroutine, it asks for an input from the user, and then it parses a <code>Console.ReadLine()</code> to an integer, however if the user inputs an integer out of the range or a letter for that matter, an exception will be thrown which will cause the program to crash.
   </td>
  </tr>
</table>

<table>
   <td colspan="5" ><strong>Question 3</strong>
   </td>
   </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><code>MakePlayerMove</code>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" ><code>CheckWin</code>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td colspan="2" ><code>GetRowColumn</code>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>4</strong>
   </td>
   <td colspan="2" >These are 2 separate subroutines, and each of them work separately from each other and only interact with the rest of the program if there’s parameters passed through, or if it interacts with a static variable of some kind which is outside of any subroutines. The variables <code>Row</code> and <code>Column</code> are defined within these subroutines separately with each other so there are no conflicts and you can tell they’re separate by seeing the variable type declaration beforehand being <code>int</code>.
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>5</strong>
   </td>
   <td colspan="2" >Using a binary file you don’t have to worry about formatting and searching through the file with a for loop or something until you find your desired ship letter, you could just read a byte value as it is. It also helps encode the file hiding it from the user so they can’t understand it, as it stores the values in literal binary code.
   </td>
  </tr>
</table>

## Section D
<table>
  <tr>
   <td colspan="5" ><strong>Question 4</strong>
   </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>4</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">
private static void GetRowColumn(ref int Row, ref int Column)
	{
		Console.WriteLine();
		Column = -1; 
		Row = -1;	
		while (Column &lt; 0 || Column > 9)
		{
			Console.Write("\rPlease enter column: ");
			var UserInput = Console.ReadLine();
			if (int.TryParse(UserInput, out Column))
			{
				if (int.Parse(UserInput) > 0 && int.Parse(UserInput) &lt; 9)
				{
					Column = int.Parse(UserInput);
					break;
				}
			}
			Console.WriteLine("Invalid value entered"); Console.CursorTop -= 2;
		}
		Console.WriteLine("                          \n                     ");
		Console.CursorTop -= 2;
		while (Row &lt; 0 || Row > 9)
		{
			Console.Write("\rPlease enter row: ");
			var UserInput = Console.ReadLine();
			if (int.TryParse(UserInput, out Row))
			{
				if (int.Parse(UserInput) > 0 && int.Parse(UserInput) &lt; 9)
				{
					Row = int.Parse(UserInput);
					break;
				}
			}
			Console.WriteLine("Invalid value entered"); Console.CursorTop -= 2;
		}
		Console.CursorTop++;
		Console.WriteLine("                     ");
}</pre>
   </td>
   </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>4</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" >
		 <img width="226" alt="image1" src="https://github.com/3leh/College/assets/37591724/6865a96a-2a95-4a7e-bf99-7f1869d1c725">
		 <img width="221" alt="image3" src="https://github.com/3leh/College/assets/37591724/f3d26001-f0a5-41a3-a6a9-9b5aceabbc6c">
   </td>
   </tr>
 </table>

<table>
  <tr>
   <td colspan="5" ><strong>Question 5</strong>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>5</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">private static bool CheckSunk(ref char[,] Board, int Row, int Column, ref ShipType[] Ships)
{
    char shipHit = Board[Row, Column];
    Board[Row, Column] = 'h';
    for (Row = 0; Row < 10; Row++)
    {
        for (Column = 0; Column < 10; Column++)
        {
            if (Board[Row, Column] == shipHit)
            {
                return false;
            }
        }
    }
    string shipHitType = null;
    for (int i = 0; i < 5; i++)
    {
        if (Ships[i].Name[0] == shipHit)
        {
            shipHitType = Ships[i].Name;
        }
    }
    Console.WriteLine($"{shipHitType} is sunk!");
    return true;
}
</td>
   </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>5</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">private static void MakePlayerMove(ref char[,] Board, ref ShipType[] Ships)
{
    int Row = 0;
    int Column = 0;
    GetRowColumn(ref Row, ref Column);
    if (Board[Row, Column] == 'm' || Board[Row, Column] == 'h')
    {
        Console.WriteLine("Sorry, you have already shot at the square (" + Column + "," + Row + "). Please try again.");
    }
    else if (Board[Row, Column] == '-')
    {
        Console.WriteLine("Sorry, (" + Column + "," + Row + ") is a miss.");
        Board[Row, Column] = 'm';
    }
    else
    {
        Console.WriteLine("Hit at (" + Column + "," + Row + ").");
        CheckSunk(ref Board, Row, Column, ref Ships);
    }
}
</td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>5</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>3</strong>
   </td>
   <td colspan="2" >
		 <img width="223" alt="image5" src="https://github.com/3leh/College/assets/37591724/ac6663b5-a656-4fbd-9333-784266572a00">
   </td>
  </tr>
</table>

<table>
  <tr>
   <td colspan="5" ><strong>Question 6</strong>
   </td>
   </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>6</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>1</strong>
   </td>
   <td colspan="2" ><pre lang="csharp">private static void MakePlayerTorpedoMove(ref char[,] Board, ref ShipType[] Ships)
{
    int Row = 0;
    int Column = 0;
    GetRowColumn(ref Row, ref Column);
    if (Board[Row, Column] == 'h')
    {
        Console.WriteLine("Torpedo has exploded!");
    }
    else
    {
        for (; Row >= 0; Row--)
        {
            if ((Board[Row, Column] == '-' || Board[Row, Column] == 'm'))
            {
                Board[Row, Column] = 'm';
            }
            else
            {
                Console.WriteLine("Hit at (" + Column + "," + Row + ").");
                CheckSunk(ref Board, Row, Column, ref Ships);
                break;
            }
        }
    }
}
// ...
private static void PlayGame(ref char[,] Board, ref ShipType[] Ships)
{
    bool GameWon = false;
    bool torpedoShot = false;
    while (GameWon == false)
    {
        PrintBoard(Board);
        if (torpedoShot == false)
        {
            Console.WriteLine("Fire a torpedo? (Y/N)");
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'Y')
            {
                MakePlayerTorpedoMove(ref Board, ref Ships);
                torpedoShot = true;
            }
            else
            {
                MakePlayerMove(ref Board, ref Ships);
            }
        }
        else
        {
            MakePlayerMove(ref Board, ref Ships);
        }
        GameWon = CheckWin(Board);
        if (GameWon == true)
        {
            Console.WriteLine("All ships sunk!");
            Console.WriteLine();
        }
    }
}</pre>
   </td>
   <td>
   </td>
  </tr>
  <tr>
   <td><strong>0</strong>
   </td>
   <td><strong>6</strong>
   </td>
   <td><strong>.</strong>
   </td>
   <td><strong>2</strong>
   </td>
   <td colspan="2" >
		 <img width="221" alt="image4" src="https://github.com/3leh/College/assets/37591724/fecd9e20-0675-4f15-9ded-4c203a7fb870">
		 <img width="220" alt="image7" src="https://github.com/3leh/College/assets/37591724/0d4967ca-960b-4276-b52d-0539ae5982fa">
   </td>
  </tr>
  </table>

