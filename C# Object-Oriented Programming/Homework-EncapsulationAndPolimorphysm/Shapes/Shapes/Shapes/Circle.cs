using System;

namespace Shapes
{
    public class Circle : IShape
    {
        private double radius;

        internal Circle(double radius) 
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Radius must have a positive value.");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            double area = Math.PI * this.Radius * this.Radius;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2d * Math.PI * this.Radius;
            return perimeter;
        }
    }
}
