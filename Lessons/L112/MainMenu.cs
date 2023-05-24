using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L112
{
    internal class MainMenu
    {
        static void Cyan(string sentence)
        {

        }
        static void Magenta(string sentence)
        {

        }
        static void List()
        {
            string[] choices = { "[ ] Display sentence normally", "[ ] Display sentence in cyan", "[ ] Display sentence in magenta", "[ ] Display sentence in the centre of the screen", "Continue" };
        }
        static void Main(string[] args)
        {
            string choice = Console.ReadKey(true).Key.ToString();
            Console.WriteLine(choice);
            switch (choice)
            {
                case "LeftArrow": // list for the choices, then do n - 1 or n + 1 in the list like List[n - 1]
                case "UpArrow":
                    break;
                case "RightArrow":
                case "DownArrow":
                    break;
                case "Enter":
                    break;
            }

            Console.ReadKey();
        }
    }
}
