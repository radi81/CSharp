namespace LongestIncreasingSequence
{
    using System;
    using System.Linq;

    public class ConsoleReader
    {
        public static int ReadNumber()
        {
            string inputLine = Console.ReadLine();
            int number = 0;

            if (string.IsNullOrEmpty(inputLine))
            {
                throw new ArgumentNullException();
            }

            try
            {
                 number = int.Parse(inputLine);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter valid integer.");
                throw;
            }

            return number;
        }

        public static int[] ConsoleReadNumbers()
        {
            string inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
            {
                throw new ArgumentNullException(inputLine);
            }

            string[] inputStrings = inputLine.Split(' ').ToArray();
            int[] inputNumbers = null;

            try
            {
                inputNumbers = inputStrings.Select(int.Parse).ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter integers, separated by a space.");
                throw;
            }

            return inputNumbers;
        }
    }
}
