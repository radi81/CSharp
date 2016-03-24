using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("This program calculates rectangles's perimeter and area " +
                "by given width and height.");
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            Console.WriteLine("Perimeter: {0}", perimeter);
            double area = width * height;
            Console.WriteLine("Area: {0}", area);
        }
    }

