using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter radius of a circle: r = ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Perimeter P = {0:0.00}", 2 * Math.PI * radius);
            Console.WriteLine("Area A = {0:0.00}", Math.PI * radius * radius);
        }
    }
