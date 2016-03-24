namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                ValidateValueToSet(value);
                this.radius = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        private static void ValidateValueToSet(double value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentNullException(
                    nameof(value),
                    "Value cannot be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(value.ToString()))
            {
                throw new ArgumentNullException(
                    nameof(value),
                    "Value cannot be null or white space.");
            }

            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    "Value cannot be equal to 0 or negative.");
            }
        }
    }
}
