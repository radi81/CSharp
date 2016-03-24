namespace LongestIncreasingSequence
{
    using System;
    using System.Linq;

    public class ConsoleReader 
    {
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
