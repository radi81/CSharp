using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;
using System.Linq;

internal class Computer
{
    private string name;
    private List<Components> components = new List<Components>();
    private decimal price;

    public Computer(string name, List<Components> components)
    {
        this.name = name;
        if (components != null)
        {
            for (int i = 0; i < components.Count; i++)
            {
                this.components.Add(components[i]);
            }
        }
        this.price = CalcTotalPrice(components);
    }

    public Computer(string name)
        : this(name, null)
    {
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid Input");
            }
            this.name = value;
        }
    }

    public List<Components> Components
    {
        get { return this.components; }
        set { this.components = value; }
    }

    public decimal Price
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

    public decimal CalcTotalPrice(List<Components> components)
    {
        decimal totalPrice = 0.0m;
        if (components != null)
        {
            for (int i = 0; i < components.Count; i++)
            {
                totalPrice += components[i].Price;
            }
        }
        return totalPrice;
    }

    public override string ToString()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        StringBuilder result = new StringBuilder();
        result.AppendLine(this.Name);
        result.AppendLine();
        foreach (var component in components)
        {
            result.AppendLine(component.ToString());
        }
        result.AppendLine();
        string totalPrice = string.Format("Total configuration price: {0:C}", this.Price);
        result.AppendLine(totalPrice); 

        return result.ToString();
    }

    public static void Main()
    {
        List<Components> procesor = new List<Components>
        {
            new Components("AMD Quad-Core A6-6310 Processor", 323m),
            new Components("Intel® Core™ i5", 345m),
            new global::Components("AMD Quad-Core A10-8700P Processor", 454m)
        };
        List<Components> memory = new List<Components>
        {
            new Components("16GB DDR3 - 2 DIMM", 234m),
            new Components("12GB DDR3L - 2 DIMM", 235m),
            new Components("8 GB DDR3L SDRAM (1 x 8 GB)", 235m)
        };
        List<Components> graphicsCards = new List<Components>
        {
            new Components("Intel® HD Graphics 520", 343m),
            new Components("AMD Radeon(TM) R6 Graphics", 324m),
            new Components("AMD Radeon(TM) R4 Graphics", 385m)
        };
        
        Computer computer1 = new Computer("HP Spectre x360 - 13-4110dx",
            new List<Components> { procesor[1], memory[2], graphicsCards[0]});
        Computer computer2 = new Computer("HP Pavilion 17z Laptop", 
            new List<Components> { procesor[2], memory[1], graphicsCards[1]});
        Computer computer3 = new Computer("HP EliteBook 840 G2 Laptop",
            new List<Components> { procesor[0], memory[0], graphicsCards[2]});

        List<Computer> computers = new List<Computer> { computer1, computer2, computer3 };
        computers = computers.OrderBy(pr => pr.Price).ToList();
        foreach (var computer in computers)
        {
            Console.WriteLine(computer.ToString());
            Console.WriteLine();
        }
    }
}

