using System;

class Person
{
    private string name;
    private int age;
    private string email;

    // Constructor with three parameters
    public Person(string name, int age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }

    // Constructor with two parameters
    public Person(string name, int age)
        : this(name, age, null) // Constructor call
    {
    }

    // Defining properties for the name
    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Enter a valid name");
            }
            this.name = value;
        }
    }

    // Defining properties for the age
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("The age should be in the range [1..100].");
            }
            this.age = value;
        }
    }

    // Defining properties for the email
    public string Email
    {
        get { return this.email; }
        set
        {
            if (!value.Contains("@") )
            {
                throw new ArgumentException("Enter a valid email");
            }
            this.email = value;
        }
    }

    public static void Main()
    {
        Person man = new Person("Pesho", 23);
        Console.WriteLine(man);
        Person woman = new Person("Mariika", 32, "mariika@abv.bg");
        Console.WriteLine(woman);
    }

    public override string ToString()
    {
        return string.Format("Name: {0}, age: {1}, email: {2}", 
            this.Name, this.Age, this.Email ?? "[not entered]");
    }
}

