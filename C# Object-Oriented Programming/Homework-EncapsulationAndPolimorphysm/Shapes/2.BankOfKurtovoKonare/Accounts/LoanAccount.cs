using _2.BankOfKurtovoKonare.Interfaces;
using System;

namespace _2.BankOfKurtovoKonare.Accounts
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal monthInterestRate)
            : base (customer, balance, monthInterestRate)
        {
        }

        public override decimal DepositMoney(decimal incomeAmount)
        {
            return base.DepositMoney(incomeAmount);
        }

        public override decimal CalculateInterest(decimal periodOfMonths)
        {
            decimal periodWithoutInterest = 0;
            if (this.Customer == Customer.Individual)
            {
                periodWithoutInterest = 3;
            }
            if (this.Customer == Customer.Company)
            {
                periodWithoutInterest = 2;
            }

            if (periodOfMonths <= periodWithoutInterest)
            {
                return 0;
            }
            else
            {
                if (this.Customer == Customer.Individual)
                {
                    return base.CalculateInterest(periodOfMonths);
                }
                else if (this.Customer == Customer.Company)
                {
                    return base.CalculateInterest(periodOfMonths);
                }
                else
                {
                    throw new Exception("The customer cannot be other than company or individual.");
                }
            }
        }

        public override decimal CalculateBalance(decimal periodOfMonths)
        {
            this.Balance += this.CalculateInterest(periodOfMonths);
            return this.Balance;
        }
    }
}
