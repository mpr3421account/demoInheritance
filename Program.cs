﻿using demoInheritance.Entities;

Account acc1 = new Account(1001, "alex", 500.0);//Classe abstrata não pode ser instanciada
Account acc2 = new SavingsAccount(1002, "anna", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(10.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);