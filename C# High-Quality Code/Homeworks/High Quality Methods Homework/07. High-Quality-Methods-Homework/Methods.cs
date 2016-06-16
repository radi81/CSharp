namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Sides must be positive.");
            }

            if (!(firstSide + secondSide > thirdSide &&
                firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide))
            {
                throw new ArgumentException(
                    "Sum of two sides must be geater than third side");
            }

            // Using Heron's formula for the area of triangle when we know the lengths of all three sides.  
            double triangleSemiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double triangleArea = Math.Sqrt(
                triangleSemiperimeter *
                (triangleSemiperimeter - firstSide) *
                (triangleSemiperimeter - secondSide) *
                (triangleSemiperimeter - thirdSide));

            return triangleArea;
        }

        public static string ConvertDigitToString(int digit)
        {
            // TO DO: Verify that input does not contains more than one 0 (por example 0000)
            // and thrrow an exception
            switch (digit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Invalid digit!");
            }
        }

        public static int FindLargestInteger(params int[] numbersToCompare)
        {
            if (numbersToCompare == null || numbersToCompare.Length == 0)
            {
                throw new ArgumentNullException(
                    nameof(numbersToCompare),
                    "List of integers to find max of them cannot be null or empty");
            }

            if (numbersToCompare.Length < 2)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(numbersToCompare),
                    "You must enter minimum 2 integers to find max of them.");
            }

            for (int currentIndex = 1; currentIndex < numbersToCompare.Length; currentIndex++)
            {
                if (numbersToCompare[0] < numbersToCompare[currentIndex])
                {
                    numbersToCompare[0] = numbersToCompare[currentIndex];
                }
            }

            int largestInteger = numbersToCompare[0];

            return largestInteger;
        }

        public static void PrintAsFormatedNumber(object number, string formater)
        {
            double outputNumber;
            if (!double.TryParse(number.ToString(), out outputNumber))
            {
                throw new FormatException(
                    "There is not entered appropriate parameter to be printed as a number.");
            }

            if (formater != "f" && formater != "%" && formater != "r")
            {
                throw new ArgumentOutOfRangeException(
                    nameof(formater),
                    "Invalid format criteria!");
            }

            if (formater == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }

            if (formater == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }

            if (formater == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        public static void AreAlignedHorizontally(
            double firstObjectCoordX,
            double firstObjectCoordY,
            double secondObjectCoordX,
            double secondObjectCoordY,
            out bool areHorizontal)
        {
            areHorizontal = firstObjectCoordY == secondObjectCoordY;
        }

        public static void AreAlignedVertically(
            double firstObjectCoordX,
            double firstObjectCoordY,
            double secondObjectCoordX,
            double secondObjectCoordY,
            out bool areVertical)
        {
            areVertical = firstObjectCoordX == secondObjectCoordX;
        }

        public static double CalculateDistance(
            double firstObjectCoordX,
            double firstObjectCoordY,
            double secondObjectCoordX,
            double secondObjectCoordY)
        {
            double distance =
                Math.Sqrt(
                    (secondObjectCoordX - firstObjectCoordX) * (secondObjectCoordX - firstObjectCoordX) +
                    (secondObjectCoordY - firstObjectCoordY) * (secondObjectCoordY - firstObjectCoordY));

            return distance;
        }
    }
}
