using System;

    class MagicWand
    {
        static void Main()
        {
            Console.WriteLine("Please enter an odd integer number in the range [5..39]:");
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            int width = 3 * n + 2;

            string line = new string('.', width / 2) + '*' + new string('.', width / 2);
            Console.WriteLine(line);

            for (int i = 1; i <= n / 2 + 1; i++)
            {
                line = new string('.', width / 2 - i) + '*' + new string('.', i * 2 - 1) + '*' + new string('.', width / 2 - i);
                Console.WriteLine(line);
            }

            line = new string('*', n) + new string('.', width - 2 * n) + new string('*', n);
            Console.WriteLine(line);

            for (int i = 1; i <= n / 2; i++)
            {
                line = new string('.', i) + '*' + new string('.', width - 2 * i - 2) + '*' + new string('.', i);
                Console.WriteLine(line);
            }

            for (int i = 1; i <= n / 2; i++)
            {
                line = new string('.', n / 2 - i) + '*' + new string('.', n / 2) + '*' + new string('.', i - 1) + '*' + new string('.', n) + 
                    '*' + new string('.', i - 1) + '*' + new string('.', n / 2) + '*' + new string('.', n / 2 - i);
                Console.WriteLine(line);
            }

            line = new string('*', n / 2 + 1) + new string('.', n / 2) + '*' + new string('.', n) +
                '*' + new string('.', n / 2) + new string('*', n / 2 + 1);
            Console.WriteLine(line);

            for (int i = 0; i < n; i++)
            {
                line = new string('.', n) + '*' + new string('.', n) + '*' + new string('.', n);
                Console.WriteLine(line);
            }

            line = new string('.', n) + new string('*', n + 2) + new string('.', n);
            Console.WriteLine(line);
        }
    }

