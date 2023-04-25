using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
                { new Account(1000), new FixedAccount(1000, 100) };
            for (int i = 0; i < 10; i++) 
            {
                accounts.ForEach(acc => acc.MakeWithdrawal(110));
                Console.WriteLine($"Account balance: {accounts[0].GetBalance()}");
                Console.WriteLine($"Fixed account balance: {accounts[1].GetBalance()}");
            }
            Console.ReadKey();
        }
    }
}
