using System;

    class CurrencyCheck
    {
        static void Main()
        {
            Console.Write("Amount of rubles at the Russian site, r = ");
            uint r = uint.Parse(Console.ReadLine());
            Console.Write("Amount of dollars at the American site, d = ");
            uint d = uint.Parse(Console.ReadLine());
            Console.Write("Amount of euro at the official site, e = ");
            uint e = uint.Parse(Console.ReadLine());
            Console.Write("Amount of leva for the special offer at site B, b = ");
            uint b = uint.Parse(Console.ReadLine());
            Console.Write("Amount of leva at site M, m = ");
            uint m = uint.Parse(Console.ReadLine());

            double priceR = r * 0.035;
            double priceD = d * 1.5;
            double priceE = e * 1.95;
            double priceB = b / 2;
            double priceM = m;
          
            double minPrice = Math.Min(Math.Min(Math.Min(Math.Min(priceR, priceD), priceE), priceB), priceM);
            Console.WriteLine("The cheapest game is {0:F2} leva.", minPrice);
        }
    }

