using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W129andW130
{
    public class SavingsAccount : Account
    {
        private double interestRate;
        public SavingsAccount(int interest, int startBalance, Customer customer) : base(startBalance, customer)
        {
            interestRate = interest;
        }
        public void AddAnnualInterest()
        {
            if (balance > 0)
            {
                balance *= 1 + interestRate;
            }
        }
    }
}
