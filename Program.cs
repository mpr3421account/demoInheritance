using demoInheritance.Entities;


Account acc = new Account(1001,"Alex", 0.0);
BusinessAccount bacc = new BusinessAccount(1002,"Maria",0.0, 500.0);

//Upcasting:

Account acc1 = bacc;
Account acc2 = new BusinessAccount(1004, "Bob", 0.0, 200.00);
Account acc3 = new SavingsAccount(1005, "Anna", 0.0, 0.01);

//Downcasting:
BusinessAccount acc4 = (BusinessAccount)acc2;
acc4.Loan(100.0);
//acc2.Loan(100.0);//Sem o downcasting gera um erro, porque o acc2 ainda é um tipo Account

//BusinessAccount acc5 = (BusinessAccount)acc3;//Não dá erro, porque o compilador não consegue prever isso, mas o erro ocorre na execução

//uma maneira de evitar o erro é testar - com if - is
if(acc3 is BusinessAccount)
{
    BusinessAccount acc5 = (BusinessAccount)acc3;
    acc5.Loan(200.0);
    Console.WriteLine("Loan!");
}
if(acc3 is SavingsAccount)
{
    SavingsAccount acc5 = (SavingsAccount)acc3;
    acc5.UpdateBalance();
    Console.WriteLine("Update!");
}
