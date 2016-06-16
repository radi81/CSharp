using System;

namespace _2.BankOfKurtovoKonare.Interfaces
{
    public interface IInterestCalculatable
    {
        decimal CalculateInterest(decimal periodOfMonths);
    }
}
