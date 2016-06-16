using System;
using _3.CompanyHierarchy.Interfaces;

namespace _3.CompanyHierarchy.Items
{
    class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        internal Sale(string productName, DateTime date, decimal price)
        {
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        DateTime ISale.date
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            return "\n" + this.GetType().Name + "\n" + "Product: " + this.ProductName + 
                this.Price + "\n" + "Sold on: " + this.Date;
        }
    }
}
