namespace SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public static class ArrayUtilities
    {
        public static double[] ReadAnArrayOfNumbers()
        {
            Console.Write("Enter numbers separated by a space: ");
            string consoleInputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(consoleInputLine))
            {
                throw new ArgumentNullException(consoleInputLine);
            }

            string[] arrayOfInputStrings = consoleInputLine.Split(' ');
            double[] arrayOfInputNumbers = null;
            try
            {
                arrayOfInputNumbers = arrayOfInputStrings
                .Select(double.Parse)
                .ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter valid doubles, separated by a space.");
                throw;
            }

            return arrayOfInputNumbers;
        }

        public static void SortArrayOfInputNumbers(double[] arrayOfInputNumbers)
        {
            Array.Sort(arrayOfInputNumbers);
        }

        public static void PrintNumbersOnTheConsole(double[] arrayOfInputNumbers)
        {
            Console.WriteLine(string.Join(" ", arrayOfInputNumbers));
        }
    }
}
