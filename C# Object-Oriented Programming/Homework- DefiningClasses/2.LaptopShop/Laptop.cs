using System;
using System.Text;
using System.Threading;
using System.Globalization;

internal class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private string rAMInGB;
    private string graphicsCard;
    private string hDD;
    private string screen;
    private decimal priceInLV;
    private Battery batterySpecification;
    private double batteryLifeInHours;

    // Full configuratin constructor
    public Laptop(string model, string manufacturer, string processor,
         string rAMInGB, string graphicsCard, string hDD, string screen,
         Battery batterySpecification, double batteryLifeInHours, decimal priceInLV)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.processor = processor;
        this.rAMInGB = rAMInGB;
        this.graphicsCard = graphicsCard;
        this.hDD = hDD;
        this.screen = screen;
        this.batterySpecification = batterySpecification;
        this.batteryLifeInHours = batteryLifeInHours;
        this.priceInLV = priceInLV;
    }

    public Laptop(string model, string manufacturer, string screen,
        double batteryLifeInHours, decimal priceInLV)
        : this(model, manufacturer, null, null, null, null, screen,
              null, batteryLifeInHours, priceInLV)
    {
    }

    public Laptop(string model, string manufacturer, string screen, decimal priceInLV)
        : this(model, manufacturer, screen, null, null, null, null, null, 0, priceInLV)
    {
    }

    public Laptop(string model, decimal priceInLV)
        : this(model, null, null, null, null, null, null, null, 0, priceInLV)
    {
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            StrException(value);
            this.model = value; ;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            StrException(value);
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            StrException(value);
            this.processor = value;
        }
    }

    public string RAMInGB
    {
        get { return this.rAMInGB; }
        set
        {
            StrException(value);
            this.rAMInGB = value;
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            StrException(value);
            this.graphicsCard = value;
        }
    }

    public string HDD
    {
        get { return this.hDD; }
        set
        {
            StrException(value);
            this.hDD = value;
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            StrException(value);
            this.screen = value;
        }
    }

    public decimal PriceInLV
    {
        get { return this.priceInLV; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            this.priceInLV = value;
        }
    }

    public Battery BatterySpecification
    {
        get { return this.batterySpecification; }
        set
        {
            StrException(value.ToString());
            this.batterySpecification = value;
        }
    }

    public double BatteryLifeInHours
    {
        get { return this.batteryLifeInHours; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }
            this.batteryLifeInHours = value;
        }
    }

    public static void StrException(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Invalid input");
        }
        return;
    }

    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        StringBuilder result = new StringBuilder();

        result.AppendLine("model: " + this.Model);

        if (this.Manufacturer != null)
        {
            result.AppendLine("manufacturer: " + this.Manufacturer);
        }

        if (this.Processor != null)
        {
            result.AppendLine("processor: " + this.Processor);
        }

        if (this.RAMInGB != null)
        {
            result.AppendLine("RAM: " + this.RAMInGB);
        }

        if (this.GraphicsCard != null)
        {
            result.AppendLine("Graphics card: " + this.GraphicsCard);
        }

        if (this.HDD != null)
        {
            result.AppendLine("HDD: " + this.HDD);
        }

        if (this.Screen != null)
        {
            result.AppendLine("screen: " + this.screen);
        }

        if (this.BatterySpecification != null)
        {
            result.AppendLine("battery: " + this.BatterySpecification);
        }

        if (this.BatteryLifeInHours != 0)
        {
            result.AppendLine("battery life: "+ this.BatteryLifeInHours);
        }

        string line = string.Format("price: {0:C}", this.PriceInLV);
        result.AppendLine(line);

        return result.ToString();
    }

    static void Main()
    {
        Laptop laptop1 = new Laptop("Lenovo Yoga 2 Pro",
            "Lenovo",
            "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
            "8 GB",
            "Intel HD Graphics 4400",
            "128GB SSD",
            "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
            new Battery("Li - Ion", 4, 2550),
            4.5,
            2259.00M);
        Console.WriteLine(laptop1);
        Console.WriteLine();

        Laptop laptop2 = new Laptop("HP 250 G2", 699.00M);
        Console.WriteLine(laptop2);
        Console.WriteLine();

        Laptop laptop3 = new Laptop("HP Spectre 13-4109na",
            "Hewlett Packard",
            "39.6 cm (15.6\") diagonal HD display",
            1200.00M);
        Console.WriteLine(laptop3);
    }
}

