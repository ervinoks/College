using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W115
{
	internal class ShoppingListSaver
	{
		struct ListItem
		{
			public string itemName;
			public string price;
		}
		static void Main(string[] args)
		{
			string fileName = @"shopping.bin", filePath = Directory.GetCurrentDirectory();
			filePath = Path.GetFullPath(Path.Combine(filePath, @"..\..\"));
			Directory.SetCurrentDirectory(filePath);
			List<ListItem> shoppingList = new List<ListItem>();
			Console.WriteLine("How many items do you want on your shopping list?");
			int listSize = int.Parse(Console.ReadLine());
			for (int i = 0; i < listSize; i++)
			{
				ListItem item = new ListItem();
				Console.Write("Input the name of the item: ");
				item.itemName = Console.ReadLine();
				Console.Write("Input the price of the item: ");
				item.price = String.Format("{0:0.00}", int.Parse(Console.ReadLine()));
				shoppingList.Add(item);
			}
			using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate)))
			{
				writer.Write($"Items in shopping list: {shoppingList.Count}");
				for (int i = 0; i < shoppingList.Count; i++)
				{
					writer.Write("•" + shoppingList[i].itemName + ": £" + shoppingList[i].price );
				}
			}
			using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.OpenOrCreate)))
			{

			}
				Console.ReadKey();
		}
	}
}
