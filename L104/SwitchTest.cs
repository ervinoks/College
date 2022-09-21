using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace L104
{
    internal class SwitchTest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your favourite fish: ");
            TextInfo textInfo = new CultureInfo("en-GB", false).TextInfo;//allows for capitalisation of both words, using System.Globalization, and en-GB locale (AKA culture), and "false" for a user override
            string bestFish = textInfo.ToTitleCase(Console.ReadLine()); //asks for input, and automatically capitalises the first letter of both words
            switch (bestFish)
            {
                case "Crucian Carp":
                    Console.WriteLine("THATS RIGHT CRUCIAN CARP IS WHERE ITS AT");
                    break;
                case "Northern Pike":
                    Console.WriteLine("come on you can do better than that");
                    break;
                case "Sturgeon Bass":
                    Console.WriteLine("thats poor from you");
                    break;
                default:
                    Console.WriteLine($"{/*char.ToUpper(*/bestFish/*[0])*/} might aswell be a Bird. you are wrong"); //commented the char.ToUpper - to show an alternative to capitalise the first letter of the string, which I didn't use
                    break;
            }
            Console.ReadKey();
        }
    }
}