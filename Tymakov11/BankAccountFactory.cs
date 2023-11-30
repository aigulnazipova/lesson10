using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov11
{
    internal class BankAccountFactory
    {
        private Hashtable bankAccounts = new Hashtable();

        public int CreateAccount(decimal balance, int accountNumber)
        {
            BankAccount newAccount = new BankAccount(balance, accountNumber);
            bankAccounts.Add(accountNumber, newAccount);
            return accountNumber;
        }

        public void CloseAccount(string accountNumber)
        {
            bankAccounts.Remove(accountNumber);
        }
    }
}
