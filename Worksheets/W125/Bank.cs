using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W125
{
	internal class Bank
	{
		static void Main(string[] args)
		{
			//Create a new account for the user
			Account account = new Account();

			string choice;
			account.overdraftLimit = account.SetOverdraftLimit(account.accountType = AccountChoice());
			do
			{
				Menu();
				choice = Console.ReadLine();
				switch (choice)
				{
					case "1":
						Console.Write("Input the amount of money you would like to deposit: ");
						int deposit = int.Parse(Console.ReadLine());
						account.MakeDeposit(deposit);
						// User makes a deposit
						break;
					case "2":
                        bool check;
						int withdraw;
                        do
						{
							Console.Write("Input the amount of money you would like to withdraw: ");
							withdraw = int.Parse(Console.ReadLine());
							check = account.CheckOverdraft(withdraw);
							Console.CursorTop--;
						}  while (check == false);
						Console.CursorTop++;
						account.MakeWithdrawal(withdraw);
                        // User makes a withdrawal
                        break;
					case "3":
						Console.WriteLine($"Your account balance is: £{account.balance}.");
						// Print the user’s balance
						break;
				}
			}
			while (choice != "9");
		}
		public static string AccountChoice()
		{
			Console.WriteLine("Would you like to open a 'standard' account or 'premium' account?" +
				"\nStandard account has an overdraft limit of 200, premium has an overdraft limit of 1000.");
			Console.Write("Input your choice: ");
			return Console.ReadLine().ToLower();
		}
		public static void Menu()
		{
			Console.WriteLine("Welcome to the Gringotts Bank");
			Console.WriteLine();
			Console.WriteLine("1. Deposit");
			Console.WriteLine("2. Withdrawal");
			Console.WriteLine("3. See Balance");
			Console.WriteLine();
			Console.WriteLine("9. Exit");
			Console.WriteLine();
		}
	}
}
