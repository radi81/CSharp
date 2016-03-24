using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("This program checks if given positive integer number n " +
                "(n <= 100) is prime.");
            int n = 1;
            bool parseSuccsess = false;
            bool isPrime= true;
            while (parseSuccsess == false)
            {
                Console.Write("Enter n = ");
                parseSuccsess = int.TryParse(Console.ReadLine(), out n);

                if (parseSuccsess == false)
                {
                    Console.WriteLine("Invalid input");
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false; break;
                }
            }
            if ((n < 1) || (n > 100))
            {
                isPrime = false;
            }
            Console.WriteLine("Prime? {0}", isPrime);
        }
    }
