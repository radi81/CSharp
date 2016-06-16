using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Roles
{
    class Manager : Employee, IManager
    {
        internal Manager(int id, string firstName, string secondName,
            decimal salary, Department department, List<IEmployee> listOfEmployees)
            : base(id, firstName, secondName, salary, department)
        {
            this.ListOfEmployees = listOfEmployees;
        }

        public List<IEmployee> ListOfEmployees { get; set; }

        public decimal ChastenEmployee(Employee employee, decimal percent)
        {
            if (percent < 0 && percent > 100 )
            {
                throw new ArgumentOutOfRangeException(
                    "Correction percent must be in range [1..100]");
            }
            decimal updatedSalary = (1 - percent) * employee.Salary;
            return updatedSalary;
        }

        public decimal RaiseEmployeesSalary(Employee employee, decimal percent)
        {
            if (percent < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Correction percent must be in range [1..100]");
            }
            decimal updatedSalary = (1 + percent) * employee.Salary;
            return updatedSalary;
        }

        public override string ToString()
        {
            return base.ToString() + "\nEmployees: " + 
                string.Join("; ", this.ListOfEmployees);
        }
    }
}

    
