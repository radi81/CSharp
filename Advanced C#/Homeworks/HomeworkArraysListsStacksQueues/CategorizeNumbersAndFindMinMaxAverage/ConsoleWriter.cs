namespace CategorizeNumbersAndFindMinMaxAverage
{
    using System;
    using System.Linq;

    public class ConsoleWriter
    {
        public static void PrintMinMaxSumAndAverageOfArray(decimal[] arrayToBePrinted)
        {
            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                string.Join(", ", arrayToBePrinted),
                arrayToBePrinted.Min(),
                arrayToBePrinted.Max(),
                arrayToBePrinted.Sum(),
                arrayToBePrinted.Average());
        }
    }
}
