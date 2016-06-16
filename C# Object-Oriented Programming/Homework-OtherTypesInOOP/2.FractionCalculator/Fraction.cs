using System;

namespace _2.FractionCalculator
{
    struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        
        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            private set
            {
                this.ValidateInputNumerator(value);
                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            private set
            {
                ValidateInputDenominator(value);
                this.denominator = value;
            }
        }

        public static Fraction operator + (Fraction firstFraction, Fraction secondFraction)
        {
            long numerator = (firstFraction.Numerator * secondFraction.Denominator +
                secondFraction.Numerator * firstFraction.Denominator);
            long denominator = firstFraction.Denominator * secondFraction.Denominator;
            return new Fraction(numerator, denominator); 
        }

        public static Fraction operator - (Fraction firstFraction, Fraction secondFraction)
        {
            long numerator = (firstFraction.Numerator * secondFraction.Denominator -
                secondFraction.Numerator * firstFraction.Denominator);
            long denominator = firstFraction.Denominator * secondFraction.Denominator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (double) this.Numerator / this.Denominator);
        }

        private void ValidateInputNumerator(long value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentNullException
                    ("Numerator must be entered");
            }

            long longNumber;
            if (!Int64.TryParse(value.ToString(), out longNumber))
            {
                throw new FormatException(
                    "Numerator must be a valid number in range " +
                    "[-9223372036854775808 … 9223372036854775807].");
            }
        }

        private void ValidateInputDenominator(long value)
        {
            if (value == 0)
            {
                throw new ArgumentNullException(
                    "Denominator cannot be 0");
            }

            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentNullException
                    ("Numerator must be entered");
            }

            long longNumber;
            if (!Int64.TryParse(value.ToString(), out longNumber))
            {
                throw new FormatException(
                    "Numerator must be a valid number in range " +
                    "[-9223372036854775808 … 9223372036854775807].");
            }
        }
    }
}
