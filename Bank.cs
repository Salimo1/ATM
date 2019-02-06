using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Bank : IBalance
    {
        public int Balance = 10000;

        public bool Compare(int amount)
        {
            if (Balance >= amount)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
