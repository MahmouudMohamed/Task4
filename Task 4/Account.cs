﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string Name = "Un Named", double Balance = 0.0)
        {
            this.Name = Name;
            this.Balance = Balance;
        }
        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public static Account operator +(Account a, Account b)
        {
            Account c = new Account();
            c.Name = a.Name;
            c.Balance = a.Balance + b.Balance;
            return c;
        }
        public override string ToString()
        {
            return $"Account: {Name}";
        }
    }
}
