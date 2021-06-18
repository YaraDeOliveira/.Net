using System;
using Accounts.Entities;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Ana", 500, 0.01);
    
            acc1.Withdraw(100.00);
            acc2.Withdraw(100.00);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

         
           













            //Account acc = new Account(1001, "Alex", 0.00);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            //// UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 2000);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 100);

            
            //// DOWNCASTING

            //BusinessAccount acc4 = (BusinessAccount)acc2;

            ////BusinessAccount acc5 = (BusinessAccount)acc3;
            

            //if (acc3 is BusinessAccount)
            //{
            //    // 2 formas de fazer o downcasting
            //    //BusinessAccount acc5 = (BusinessAccount)acc3;
            //    BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}

            //if (acc3 is SavingsAccount)
            //{
            //    //SavingsAccount acc5 = (SavingsAccount)acc3;
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    Console.WriteLine(acc5.Holder);
            //    Console.WriteLine(acc3.Holder);
               
            //    acc5.UptadeBalance();
            //    Console.WriteLine("Update!");
            
        }
    }
}
