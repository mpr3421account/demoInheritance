using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoInheritance.Entities
{
    internal class SavingsAccount : Account//adicionado sealed para que seja impossibilitado criar um sub classe de Savingsaccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestrate) : base(number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)//adicionado o sealed para bloquear que outro método sobrescreva esse método
        {
            base.Withdraw(amount);//com o base o método foi reaproveitado da super classe account
            Balance -= 2.0;//adiciona uma condição para essa classe SavingsAccount
        }
    }
}
