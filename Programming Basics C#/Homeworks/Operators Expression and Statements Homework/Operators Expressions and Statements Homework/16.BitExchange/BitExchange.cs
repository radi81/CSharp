using System;

    class BitExchange
    {
        static void Main()
        {
            Console.WriteLine("This program exchanges bits {p, p+1, ....p+k-1} " +
                "with bits {q,q+1, ..., q+k-1} of a given 32-bit unsigned integer n.");
            uint n = 0;
            uint k = 1;
            int p = 0;
            int q = 0;
            bool parseSuccsess_n = false;
            bool parseSuccsess_k = false;
            bool parseSuccsess_p = false;
            bool parseSuccsess_q = false;
            while(parseSuccsess_n == false)
            {
                Console.Write("n = ");
                parseSuccsess_n = uint.TryParse(Console.ReadLine(), out n);
                if( parseSuccsess_n == false)
                {
                    Console.WriteLine("Invalid input. Enter unsigned integer " + 
                    "in the range (0, 4 294 967 295)");
                }
            }
            while(parseSuccsess_k == false)
            {
                Console.Write("k = ");
                parseSuccsess_k = uint.TryParse(Console.ReadLine(), out k);
                if (parseSuccsess_k == false)
                {
                    Console.WriteLine("Invalid input. Enter unsigned integer between 1 and 33");
                }
            }
            while(parseSuccsess_p == false)
            {
                Console.Write("p = ");
                parseSuccsess_p = int.TryParse(Console.ReadLine(), out p);
                if (parseSuccsess_p == false)
                {
                    Console.WriteLine("Invalid input. Enter unsigned integer between 0 and 31.");
                }
            }
            while(parseSuccsess_q == false)
            {
                Console.Write("q = ");
                parseSuccsess_q = int.TryParse(Console.ReadLine(), out q);
                if (parseSuccsess_q == false)
                {
                    Console.WriteLine("Invalid input. Enter unsigned integer between 0 and 31.");
                }
            }
            uint mask1 = 

        }
    }

