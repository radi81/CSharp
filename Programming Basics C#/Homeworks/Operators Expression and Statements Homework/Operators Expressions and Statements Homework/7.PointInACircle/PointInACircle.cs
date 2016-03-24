using System;

    class PointInACircle
    {
        static void Main()
        {
            Console.WriteLine("This program checks if given point (x, y) is " +
                "inside a circle K({0, 0}, 2).");
            Console.Write("Enter x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter y = ");
            double y = double.Parse(Console.ReadLine());

            // (x - x1)^2 + (y - y1)^2 <= R^2; X1 = 0; X2 = 0
    
            Console.WriteLine("Inside? {0}", (x * x + y * y <= 4));   
        }
    }

