using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAccounts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount objSavingsAccount = new SavingsAccount();
            objSavingsAccount.BankName();
            objSavingsAccount.CheckCurrentBalance();
            objSavingsAccount.TransferMoney();
            objSavingsAccount.AccountNo = "887766"; 
            Console.WriteLine();
            objSavingsAccount.Withdraw();
            CurrentAccount objCurrentAccount = new CurrentAccount();
            objCurrentAccount.BankName();
            objCurrentAccount.CheckCurrentBalance();
            objCurrentAccount.TransferMoney();
            objCurrentAccount.AccountNo = "112233";
            Console.WriteLine("Account Number: "+ objSavingsAccount.AccountNo);
            string msg = objSavingsAccount.Deposit(1000);
            Console.WriteLine(msg);

        }
    }
}
