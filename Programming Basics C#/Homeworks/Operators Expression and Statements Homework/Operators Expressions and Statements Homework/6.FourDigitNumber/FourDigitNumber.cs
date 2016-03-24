using System;

    class FourDigitNumber
    {
        static void Main()
        {
            int n = 0;
            bool parseSuccsess = false;
            while (parseSuccsess == false)
            {
                Console.Write("Enter a four-digit number in format abcd: ");
                parseSuccsess = int.TryParse(Console.ReadLine(), out n);
                if (parseSuccsess == false)
                {
                    Console.WriteLine("Invalid input. Try again!");
                }
                if ((n < 1000)||(n > 9999))
                {
                    Console.WriteLine("Invalid format. Try again!");
                    parseSuccsess = false;
                }
            }

            int d = n % 10;
            int c = (n / 10) % 10;
            int b = (n / 100) % 10;
            int a = (n / 1000) % 10;
            string str_a = a.ToString();
            string str_b = b.ToString();
            string str_c = c.ToString();
            string str_d = d.ToString();

            Console.WriteLine("The sum of the digits is {0}", a + b + c + d);
            Console.WriteLine("The number in reversed order is {0}",
                str_d + str_c + str_b + str_a);
            Console.WriteLine("With the last digid in the first position: {0}", 
                str_d + str_a + str_b + str_c);
            Console.WriteLine("With the second and the third digits exchanged: {0}",
                str_a + str_c + str_b + str_d);
        }
    }

