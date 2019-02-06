using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Account
    {
        Transaction t1 = new Transaction();
        Bank b1 = new Bank();
        public int amount { get; set; }

        public Account(int amount)
        {
            this.amount = amount;
        }

        public string Withdraw(Account a1)
        {
            
            b1.Compare(a1.amount);
            if (b1.Compare(a1.amount) == true)
            {
                int resultReturn = t1.Withdraw(a1, b1);
                string message = "You have withdrawn: " + resultReturn;
                return message;
            }
            return "Somethings gone wrong, sorry try again!";
        }

        public string InsertMoney(Account a1)
        {
                int resultReturn = t1.InsertMoney(a1, b1);
                string message = "You have deposited: " + a1.amount + " and now have :" + b1.Balance + " in your bank acccount";
                return message;
        }

    }
}
