using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write(" Enter a possitive integer number n = ");
            uint n = uint.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum = 0;
            Console.Write("0, ");

            for (int i = 0; i < n-1 ; i++)
            {
                a = b;
                b = sum;
                sum = a + b;
                Console.Write("{0}, ", sum);
            }
        }
    }

