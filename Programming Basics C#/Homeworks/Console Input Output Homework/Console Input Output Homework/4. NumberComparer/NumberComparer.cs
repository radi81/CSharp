using System;

    class NumberComparer
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
       
            Console.WriteLine("Greater number is : {0}", 
                Math.Max(firstNumber, secondNumber));
        }
    }

