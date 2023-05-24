using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W129andW130
{
    public class Account
    {
        protected double balance;
        private double overDraftLimit;
        protected Customer customer;

        public Account(double startBalance, Customer customer)
        {
            this.customer = customer;
            balance = startBalance;
            if (customer.isPremium()) overDraftLimit = 1500;
            else overDraftLimit = 0;
            
        }

        public void makeDeposit(int amount)
        {
            balance += amount;
        }

        public double getBalance()
        {
            return balance;
        }

        public void makeWithdrawal(int amount)
        {
            if (balance + overDraftLimit >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient funds.");
            }
        }
    }
}
