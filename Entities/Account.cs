using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInheritance.Entities
{
    internal abstract class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account() { 
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)//virtual libera o método que será sobrescrito/sobreposto (override)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
