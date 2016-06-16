using System;
using System.Collections.Generic;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Roles
{
    class SalesEmployee : Employee, ISalesEmployee
    {
        internal SalesEmployee(int id, string firstName, string lastName,
            decimal salary, Department department, List<ISale> listOfSales)
            : base(id, firstName, lastName, salary, department)
        {
            this.ListOfSales = listOfSales;
        }

        public List<ISale> ListOfSales { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nWork: " +
                string.Join("; ", this.ListOfSales);
        }
    }
}
