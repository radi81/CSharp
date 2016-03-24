using System;

    class DivideBy7And5
    {
        static void Main()
        {  
            int n = 0;
            bool parseSuccess = false;

            while (parseSuccess == false)
            {
                Console.Write("Please enter an integer: n = ");
                parseSuccess = int.TryParse(Console.ReadLine(), out n);
                if (parseSuccess == false)
                {
                    Console.WriteLine("Invalid input. Try again!");
                    parseSuccess = false;
                }
            }

            Console.WriteLine("Divided by 7 and 5? {0}", (n % 5 == 0) && (n % 7 == 0));
        }
    }

