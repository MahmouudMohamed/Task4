using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class CheckingAccount : Account
    {
        public double Fee { get; }
        public CheckingAccount(string name = "My Checking Account", double balance = 0)
        : base(name, balance)
        {
            Fee = 1.5;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount + Fee);
        }
    }
}
