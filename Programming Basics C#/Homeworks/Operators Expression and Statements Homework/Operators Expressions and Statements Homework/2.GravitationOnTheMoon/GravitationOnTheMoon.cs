using System;

    class GravitationOnTheMoon
    {
        static void Main()
        { 
            double weightOnTheEarth = 0;
            bool parseSuccess = false;
            while (parseSuccess == false)
            {
                Console.Write("Weight on Earth: m1 = ");
                parseSuccess = double.TryParse(Console.ReadLine(), out weightOnTheEarth);
                if (parseSuccess == false)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
                if (weightOnTheEarth <= 0)
                {
                    Console.WriteLine("m1 should be positive. Enter new value.");
                    parseSuccess = false;
                }
            }
   
            //Gravitational acceleration: g = m / (r^2) => m2 /m1 = g2 / g1 => m2 = (17 / 100) * m1
            double weightOnTheMoon = (17.0 / 100) * weightOnTheEarth;

            Console.WriteLine("Weght on the Moon : m2 = {0}", weightOnTheMoon);
        }
    }
