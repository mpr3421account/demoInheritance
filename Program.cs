using demoInheritance.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

List<Account> list = new List<Account>();

list.Add(new SavingsAccount(1001, "Maria", 500.0, 0.01));
list.Add(new BusinessAccount(1002, "Bob", 500.0, 800.0));
list.Add(new SavingsAccount(1003, "Sucker", 500.0, 0.01));
list.Add(new BusinessAccount(1004, "Fucker", 500.0, 900.0));

double sum = 0.0;
foreach(Account acc in list)
{
    sum += acc.Balance;
}
Console.WriteLine("Total balance sum: $ " + sum);
foreach(Account acc in list)
{
    acc.Withdraw(10.0);
}
foreach(Account acc in list)
{
    Console.WriteLine(acc.Balance);
}