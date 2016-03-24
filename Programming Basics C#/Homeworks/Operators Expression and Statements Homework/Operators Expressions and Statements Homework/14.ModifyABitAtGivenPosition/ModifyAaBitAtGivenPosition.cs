using System;

    class ModifyAaBitAtGivenPosition
    {
        static void Main()
        {
            long n = 1;
            byte v = 1;
            int p = 1;
            bool parseSuccess_n = false;
            bool parseSuccess_v = false;
            bool parseSuccess_p = false;
            long mask;
            long result;

            while (parseSuccess_n == false)
            {
                Console.Write("Enter an integer number n = ");
                parseSuccess_n = long.TryParse(Console.ReadLine(), out n);
                if (parseSuccess_n == false) 
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }
            
            while (parseSuccess_v == false) 
            {
                Console.Write("Enter the bit value - 0 or 1: ");
                parseSuccess_v = byte.TryParse(Console.ReadLine(), out v);
                if (parseSuccess_v == false)
                {
                    Console.WriteLine("Invalid input. Try again!");
                    parseSuccess_v = false;
                }
                if ((v == 0) || (v == 1))
                {
                    break;
                }
                else
                {
                    parseSuccess_v = false;
                } 
            }

            while (parseSuccess_p == false)
            {
                Console.Write("Enter position p = ");
                parseSuccess_p = int.TryParse(Console.ReadLine(), out p);
                if (parseSuccess_p == false)
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }

            mask = 1 << p;
            if (v == 0)
            {
                result = n & (~mask);
            }
            else
            {
                result = n | mask;
            }
            Console.WriteLine("Result: {0}", result);
        }
    }


