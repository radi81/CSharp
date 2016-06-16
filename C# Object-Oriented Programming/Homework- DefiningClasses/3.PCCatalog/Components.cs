using System;
using System.Threading;
using System.Globalization;

internal class Components 
{
    private string name;
    private string details;
    private decimal price;

    public Components(string name, string details, decimal price)
    {
        this.name = name;
        this.details = details;
        this.price = price;
    }

    public Components(string name, decimal price)
        : this(name, null, price)
    {
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (this.name == null)
            {
                throw new ArgumentException("Invalid input");
            }
            this.name = value;
        }
    }

    public string Details
    {
        get { return this.details; }
        set { this.details = value; }
    }

    public Decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0M)
            {
                throw new ArgumentException("Invalid input");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        return string.Format("{0} : {1:C}  {2}", this.Name, this.Price, this.Details ?? null);
    }
}

