using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A125
{
    public class FixedAccount : Account
    {
        private int withdrawalFee;
        public FixedAccount(int startBalance, int withdrawalFee) : base(startBalance)
        {
            this.withdrawalFee = withdrawalFee;
        }
        public override void MakeWithdrawal(int amount)
        {
            base.MakeWithdrawal(amount);
            if (balance > 0) { balance -= withdrawalFee; }
            if (balance < 0) { balance = 0; }
        }
    }
}
