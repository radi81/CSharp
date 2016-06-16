using System;
using _2.BankOfKurtovoKonare.Accounts;

namespace _2.BankOfKurtovoKonare
{
    class Program
    {
        static void Main()
        {
            // Loan account
            Account person1Loan = new LoanAccount(Customer.Individual, 400m, 0.012m);
            Console.WriteLine(person1Loan.CalculateInterest(2));
            Console.WriteLine(person1Loan.CalculateInterest(6));
            Console.WriteLine(person1Loan.CalculateBalance(6));
            person1Loan.DepositMoney(150m);
            Console.WriteLine(person1Loan.Balance);
            Console.WriteLine();

            // Deposit account
            DepositAccount firm1Deposit = new DepositAccount(Customer.Company, 150m, 0.003m); //It is possible to withdraw only via object of type depositAccount
            Console.WriteLine(firm1Deposit.CalculateInterest(5));
            firm1Deposit.DepositMoney(800000m);
            Console.WriteLine(firm1Deposit.CalculateInterest(1));
            Console.WriteLine(firm1Deposit.CalculateBalance(1));
            firm1Deposit.WithdrawMoney(4500);         
            Console.WriteLine(firm1Deposit.Balance);
            Console.WriteLine();

            // Mortdade account
            Account person1Mortgage = new MortgageAccount(Customer.Individual, 20000m, 0.006m);
            Console.WriteLine(person1Mortgage.CalculateInterest(6));
            Console.WriteLine(person1Mortgage.CalculateInterest(7));
            Console.WriteLine(person1Mortgage.CalculateBalance(7));
        }
    }
}
