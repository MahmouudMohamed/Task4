using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class TrustAccount : SavingsAccount
    {
        private int targetWithDrawals;
        private int counterWithDrawals;

        public TrustAccount(string name = "My Trust Account", double balance = 0.0, double interestRate = 0.0)
            : base(name, balance, interestRate)
        {
            targetWithDrawals = 3;
            counterWithDrawals = 0;
        }

        public override bool Deposit(double amount)
        {
            if (amount > 0)
            {
                if (amount >= 5000)
                    amount += 50;
                return base.Deposit(amount);
            }
            return false;
        }

        public override bool Withdraw(double amount)
        {
            if (counterWithDrawals >= targetWithDrawals)
            {
                Console.WriteLine("=========================================================================================================");
                Console.WriteLine($"limit of withdraw reached for the year.{base.Name}");
                Console.WriteLine("=========================================================================================================");
                return false;
            }

            if (amount > Balance * 0.2)
            {
                Console.WriteLine($"Can't withdraw {amount}. You Can't withdraw more than 20% of the balance. Maximum allowed: {Balance * 0.2}");
                Console.WriteLine("=========================================================================================================");

                return false;
            }
            else 
            {
                counterWithDrawals++;
                return base.Withdraw(amount);
            }

          

      
        }
    }
}
