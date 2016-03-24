using System;

    class NumbersDividableByGivenNum
    {
        static void Main()
        {
            Console.WriteLine("Enter two possitive integer numbers: ");
            Console.Write("start a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("end b = ");
            int b = int.Parse(Console.ReadLine());

            int p = (b / 5) - ((a - 1) / 5);
            Console.WriteLine("There are {0} numbers between them such " +
            "that the reminder of the division by 5 is O.", p);
        }
    }

