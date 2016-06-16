using System;
using _2.BankOfKurtovoKonare.Interfaces;


namespace _2.BankOfKurtovoKonare.Accounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal monthInterestRate)
            : base (customer, balance, monthInterestRate)
        {
        }

        public override decimal DepositMoney(decimal incomeAmount)
        {
            return base.DepositMoney(incomeAmount);
        }

        public override decimal CalculateInterest(decimal periodOfMonths)
        {
            decimal promotionPeriod = 0;
            if (this.Customer == Customer.Individual)
            {
                promotionPeriod = 6;
            }
            if (this.Customer == Customer.Company)
            {
                promotionPeriod = 12;
            }

            if (periodOfMonths <= promotionPeriod)
            {
                if (this.Customer == Customer.Individual)
                {
                    return 0;
                }
                else if (this.Customer == Customer.Company)
                {
                    return base.CalculateInterest(periodOfMonths - 12) / 2;
                }
                else
                {
                    throw new Exception("The customer cannot be other than company or individual.");
                }
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
            this.Balance += CalculateInterest(periodOfMonths);
            return this.Balance;
        }
    }
}
