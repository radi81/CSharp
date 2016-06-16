using System;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface ICustomer : IPerson
    {
        decimal NetPurchaseAmount { get; set; }
    }
}
