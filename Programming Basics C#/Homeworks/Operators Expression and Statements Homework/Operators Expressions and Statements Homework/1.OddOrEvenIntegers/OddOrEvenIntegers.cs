using System;

    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Input an integer n = ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Odd? {0}", n % 2 != 0);
        }
    }

