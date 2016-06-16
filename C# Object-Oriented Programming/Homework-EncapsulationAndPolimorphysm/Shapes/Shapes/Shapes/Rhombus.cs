using System;

namespace Shapes.Shapes
{
    public class Rhombus : BasicShape
    {
       internal Rhombus(double width, double height)
            :base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double area = base.Width * base.Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 4d * base.Width;
            return perimeter;
        }
    }
}
