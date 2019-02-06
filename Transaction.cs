using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Transaction
    {

        public int Withdraw(Account account, Bank bank)
        {
            bank.Balance -= account.amount;
            return account.amount;
        }

        public int InsertMoney(Account account, Bank bank)
        {
            bank.Balance += account.amount;
            return bank.Balance;
        }
    }
}
