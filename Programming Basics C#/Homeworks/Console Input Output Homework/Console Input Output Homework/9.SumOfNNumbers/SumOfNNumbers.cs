using System;

    class SumOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter a possitive integer number n = ");
            uint n = uint.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                double enteredNumber = double.Parse(Console.ReadLine());
                sum += enteredNumber;
            }
            Console.WriteLine("The sum of numbers is: {0}", sum);
        }
    }

