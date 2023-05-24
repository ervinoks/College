using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W129andW130
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account(100, new Customer("Me", true));
            Account yourAccount = new Account(100, new Customer("You", false));

            Console.WriteLine("My balance: " + myAccount.getBalance());
            Console.WriteLine("Your balance: " + myAccount.getBalance());
            Console.ReadKey();

            myAccount.makeWithdrawal(100);
            Console.WriteLine("My balance: " + myAccount.getBalance());
            Console.ReadKey();

            yourAccount.makeWithdrawal(100);
            Console.WriteLine("Your balance: " + myAccount.getBalance());
            Console.ReadKey();

            myAccount.makeWithdrawal(100);
            Console.WriteLine("My balance: " + myAccount.getBalance());
            Console.ReadKey();

            yourAccount.makeWithdrawal(100); // will throw insufficient funds exception
            Console.WriteLine("Your balance: " + myAccount.getBalance());
            Console.ReadKey();
        }
    }
}
