using System;
using Shapes.Shapes;

namespace Shapes
{
    class Program 
    {
        static void Main()
        {
            IShape[] figures =  
                {
                new Rectangle(4, 5),
                new Rectangle(3.4, 12.9),
                new Circle(4.2),
                new Rhombus(36.44, 0.1),
                new Circle(15)
                };

            foreach (var figure in figures)
            {
                Console.WriteLine("Figure: " + figure.GetType().Name + "\n" + "Area: " + 
                    figure.CalculateArea() + "\n" + "Perimeter: " + figure.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
