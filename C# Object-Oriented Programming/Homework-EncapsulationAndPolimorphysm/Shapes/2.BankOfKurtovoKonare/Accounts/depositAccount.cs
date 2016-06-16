using System;
using _2.BankOfKurtovoKonare.Interfaces;

namespace _2.BankOfKurtovoKonare.Accounts
{
    public class DepositAccount: Account, IWithdraw
    {
        public DepositAccount(Customer customer, decimal balance, decimal monthInterestRate)
            : base (customer, balance, monthInterestRate)
        {
        }

        public override decimal DepositMoney(decimal incomeAmount)
        {
            return base.DepositMoney(incomeAmount);
        }
        
        public decimal WithdrawMoney(decimal outcomeAmount)
        {
            this.Balance -= outcomeAmount;
            return this.Balance; 
        }

        public override decimal CalculateInterest(decimal periodOfMonths)
        {
            if (this.Balance > 0m && this.Balance < 1000m)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterest(periodOfMonths);
            }
        }

        public override decimal CalculateBalance(decimal periodOfMonths)
        {
            this.Balance += this.CalculateInterest(periodOfMonths);
            return this.Balance;
        }
    }
}

