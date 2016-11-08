using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day920ProgramInheritance
{
    class CheckingAccount : Account
    {

        public override int Deposit(int money)
        {
            return base.Deposit(money);
        }
    }
}
