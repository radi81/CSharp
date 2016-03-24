using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("This program reads the coefficients a, b and c " +
            "of a quadratic equation and prints its real roots");
            Console.Write("a = (different from 0)");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("x1 = {0}", (-b-Math.Sqrt(b*b - 4*a*c))/(2*a));
            Console.WriteLine("x2 = {0}", (-b+Math.Sqrt(b*b - 4*a*c))/(2*a));
        }
    }
