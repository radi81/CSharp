using System;

namespace Shapes.Shapes
{
    public class Rectangle : BasicShape
    {
        internal Rectangle(double width, double height)
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
            double perimeter = 2d * (base.Width + base.Height);
            return perimeter;
        }
    }
}
