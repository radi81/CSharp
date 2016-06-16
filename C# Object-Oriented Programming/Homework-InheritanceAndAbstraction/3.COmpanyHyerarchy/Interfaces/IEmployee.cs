using System;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IEmployee : IPerson
    {
        decimal Salary { get; set; }
        Department Department { get; set; }
    }
}
