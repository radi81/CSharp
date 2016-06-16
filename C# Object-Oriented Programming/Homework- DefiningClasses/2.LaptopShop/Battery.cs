using System;

internal class Battery
{
    private string type;
    private int numberOfCells;
    private int mAh;

    public Battery(string type, int cells, int mAh)
    {
        this.type = type;
        this.numberOfCells = cells;
        this.mAh = mAh;
    }
    
    public string Type
    {
        get { return this.type; }
        set
        {
            Laptop.StrException(value);
            this.type = value;
        }
    }

    public int NumberOfCells
    {
        get { return this.numberOfCells; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
        }
    }
    
    public int MAh
    {
        get { return this.mAh; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}-cells, {2} mAh",
            this.type, this.NumberOfCells, this.MAh);
    }
}

