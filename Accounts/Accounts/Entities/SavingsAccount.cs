using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2;
        }

        public void UptadeBalance()
        {
            Balance += Balance * InterestRate;
        }

    }
}
