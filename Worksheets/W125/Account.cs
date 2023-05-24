using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W125
{
	public class Account
	{
		public int balance, overdraftLimit;
		public string accountType;

		public int SetOverdraftLimit(string accountType)
		{
			if (accountType == "standard")
				return -200;
			else if (accountType == "premium")
				return -1000;
			else
				return 0;
		}
		public void MakeDeposit(int amount)
		{
			balance += amount;
		}
		public void MakeWithdrawal(int amount)
		{
			balance -= amount;
		}
		public bool CheckOverdraft(int amount)
		{
			if (balance - amount < overdraftLimit) { return false; }
			else { return true; }
		}
	}
}
