using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W135
{
    internal class Adjacency
    {
        private Dictionary<int, string> people;
        virtual public void Menu()
        {
            int GetMainMenuChoice()
            {
                int Choice = -1;
                do
                {
                    Console.Write("\rPlease enter your choice: ");
                    var UserInput = Console.ReadKey();
                    if (char.IsDigit(UserInput.KeyChar)) { Choice = int.Parse(UserInput.KeyChar.ToString()); }
                    Console.WriteLine("\nPlease input one of the numbers shown.");
                    Console.CursorTop -= 2;
                } while (Choice != 1 && Choice != 2 && Choice != 3 && Choice != 4 && Choice != 9);
                Console.Clear(); return Choice;
            }
            Console.WriteLine("1: Add people" + 
                "\n2: Add a friendship" +
                "\n3: Check a friendship" +
                "\n4: Find index" +
                "\n9: Quit");
            int Option = GetMainMenuChoice();
            switch (Option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
            }

        }
        virtual public void MakeFriends(int input1, int input2)
        {

        }
        virtual public bool CheckFriendship(int input1, int input2)
        {

        }
        virtual public int FindIndex()
        {

        }
    }
}
