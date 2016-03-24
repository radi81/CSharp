namespace CategorizeNumbersAndFindMinMaxAverage
{
    using System;
    using System.Linq;

    public class ConsoleReader
    {
        public static decimal[] ConsoleReadNumbers()
        {
            string inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
            {
                throw new ArgumentNullException(inputLine);
            }

            string[] inputStrings = inputLine.Split(' ').ToArray();
            decimal[] inputNumbers = null;

            try
            {
                inputNumbers = inputStrings
                    .Select(decimal.Parse)
                    .ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "You have to enter valid floating-point numbers, separated by a space.");
                throw;
            }
            
            return inputNumbers;
        }
    }
}
