using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Roles
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        internal Customer(decimal netPurchaseAmount, int id, 
            string firstName, string secondName)
            : base(id, firstName, secondName)
        {
            this.netPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get
            {
                return this.netPurchaseAmount;
            }
            set
            {
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + "Total: " +
                this.NetPurchaseAmount;
        }
    }
}
