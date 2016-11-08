using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day920ProgramInheritance
{
    class Account
    {

        public virtual int Deposit(int money)
        {
            int accountBalance = 1000;
            accountBalance += money;
            return accountBalance;
        }

        public virtual int Withdraw(int money)
        {
            int accountBalance = 1000;
            accountBalance -= money;
            return accountBalance; 
        }

    }
}
