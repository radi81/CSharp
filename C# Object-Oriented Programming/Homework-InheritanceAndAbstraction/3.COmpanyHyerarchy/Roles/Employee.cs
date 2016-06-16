using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Roles
{
    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        public Department department;

        protected Employee(int id, string firstName,
            string lastName, decimal salary, Department department)
            : base(id, firstName, lastName)
        {
            this.salary = salary;
            this.department = department;
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
            
        public Department Department { get; set; }
        
        public override string ToString()
        {
            return base.ToString() + string.Format(
                ", Salary {0}, Department: {1}", this.Salary, this.Department);
        }
    }
}
