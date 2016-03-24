using System;

    class IsThirdDigit7
    {
        static void Main()
        {
            Console.WriteLine("This program checks for given integer if its third digit "+
            "from right-to-left is 7");
            int n = 0;
            bool parseSuccess = false;
            while (parseSuccess == false)
            {
                Console.Write("Enter an integer n = ");
                parseSuccess = int.TryParse(Console.ReadLine(), out n);
                if (parseSuccess == false)
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
            }
          
            Console.WriteLine("Third digit 7? {0}", ((n / 100) % 10 == 7));
        }
    }





