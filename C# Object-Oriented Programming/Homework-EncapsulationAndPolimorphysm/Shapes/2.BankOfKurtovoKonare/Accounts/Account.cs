using System;
using _2.BankOfKurtovoKonare.Interfaces;

namespace _2.BankOfKurtovoKonare
{
    public abstract class Account : IInterestCalculatable, IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal monthInterestRate;

        protected Account(Customer customer, decimal balance, decimal monthInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthInterestRate = monthInterestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            protected set 
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                Validation.CheckForEmptyOrNull(value.ToString(), "balance");
                Validation.CheckForEmptyOrWhiteSpase(value.ToString(), "balance");
                this.balance = value;
            }
        }

        public decimal MonthInterestRate
        {
            get
            {
                return monthInterestRate;
            }
            set
            {
                Validation.CheckForEmptyOrNull(value.ToString(), "monthly based interest rate");
                Validation.CheckForEmptyOrWhiteSpase(value.ToString(), "monthly based interest rate");
                this.monthInterestRate = value;
            }
        }

        public virtual decimal DepositMoney(decimal incomeAmount)
        {
            this.Balance += incomeAmount;
            return this.Balance;
        }

        public virtual decimal CalculateInterest(decimal periodOfMonths)
        {
            decimal interest = this.Balance * this.monthInterestRate * periodOfMonths;
            return interest;
        }
  
        public virtual decimal CalculateBalance(decimal periodOfMonths)
        {
            this.Balance += this.CalculateInterest(periodOfMonths);
            return this.Balance;
        }
    }
}
