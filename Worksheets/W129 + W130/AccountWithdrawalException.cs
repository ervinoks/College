using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W129andW130
{
    public class AccountWithdrawalException : Exception
    {
        private Account account;
        AccountWithdrawalException(Account account)
        {
            this.account = account;
        }
        public void GetOwnerName()
        {
            
        }
    }
}
