namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        } 

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                ValidateValueToSet(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                ValidateValueToSet(value);
                this.height = value;
            }
        }

        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
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
