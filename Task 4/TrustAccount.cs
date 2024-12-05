using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class TrustAccount : SavingsAccount
    {
        private int counter;
        private DateTime date;
        public TrustAccount(string name = "My Trust Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance, interestRate)
        {
            counter = 1;
            date = DateTime.Now;
        }


        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                amount += 50;
            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (counter > 3 || amount > 0.2 * Balance)
            { 
                return false;
            }
            else
            {
                counter++;
                return base.Withdraw(amount);
            }
        }
    }
}
