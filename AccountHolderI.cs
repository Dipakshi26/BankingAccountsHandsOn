using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts
{
    internal interface AccountHolderI
    {
        void Withdraw();
        void CheckCurrentBalance();
        void ResetAtmPin();
        void TransferMoney();
    }
}
