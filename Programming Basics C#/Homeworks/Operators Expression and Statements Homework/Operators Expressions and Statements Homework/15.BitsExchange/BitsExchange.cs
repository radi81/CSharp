using System;

class BitsExchange
    {
        static void Main()
        {
            Console.WriteLine("This program exchanges bits 3, 4 and 5 with " +
                "bits 24, 25 and 26 of given 32-bit unsigned integer. /n Enter " +
                "an integer in range (0, 4 294 967 295)");
            uint n = 0;
            bool parseSuccsess = false;

            while (parseSuccsess == false)
            {
                Console.Write("n = ");
                parseSuccsess = uint.TryParse(Console.ReadLine(), out n);
                if (parseSuccsess == false)
                {
                    Console.WriteLine("Invalid input. Enter an unsigned integer.");
                }
            }

            uint mask = (7 << 3) | (7 << 24);
            uint first3Bits = ((mask & n) >> 3) & 7;
            uint second3Bits = ((mask & n) >> 24) & 7;

            uint result = (~mask & n) | ((first3Bits << 24) | (second3Bits << 3));
            Console.WriteLine("result: {0}", result);          
        }
    }
