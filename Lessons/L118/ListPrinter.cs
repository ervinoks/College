using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L117
{
    internal class ListPrinter
    {
        static void PrintList(List<string> shoppingList)
        {
            string output = "[";
            foreach (string item in shoppingList) { if (item == shoppingList[shoppingList.Count - 1]) { output += $"{item}]"; } else { output += $"{item}, "; } }
            // Console.WriteLine("[" + string.Join(", ", shoppingList) + "]"); 
            Console.WriteLine(output);
        }
        static void Main(string[] args)
        {
            List<string> ingredients = new List<string>(); ingredients.InsertRange(ingredients.Count, new string[] { "Eggs", "Milk", "Flour", "Butter" });
            //for (int i = 0; i < ingredients.Count; i++) { Console.WriteLine(ingredients[i]); }
            PrintList(ingredients);
            Console.ReadKey();
        }
    }
}
