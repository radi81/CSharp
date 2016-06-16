using System;
using _3.CompanyHierarchy.Roles;

namespace _3.CompanyHierarchy.Interfaces
{
    public interface IManager 
    {
        decimal Salary { get; set; }
        Department Department { get; set; }

        decimal ChastenEmployee(Employee employee, decimal percent);
        decimal RaiseEmployeesSalary(Employee employee, decimal percent);
    }
}
