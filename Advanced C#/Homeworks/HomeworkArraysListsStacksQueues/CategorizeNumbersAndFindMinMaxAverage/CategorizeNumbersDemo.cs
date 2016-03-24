namespace CategorizeNumbersAndFindMinMaxAverage
{
    using System.Linq;

    public class CategorizeNumbersDemo
    {
        public static void Main(string[] args)
        {
            decimal[] numbersToBeSeparated = ConsoleReader.ConsoleReadNumbers();
            int numberOfRoundNumbers = 
                numbersToBeSeparated.Count(number => number % 1m == 0m);
            int numberOfNumbersWithNonZeroFractions =
                numbersToBeSeparated.Length - numberOfRoundNumbers;

            decimal[] numberSetWithZeroFractions = 
                new decimal[numberOfRoundNumbers];
            decimal[] numberSetWithNonZeroFractions = 
                new decimal[numberOfNumbersWithNonZeroFractions];

            int index1 = 0;
            int index2 = 0;
            foreach (var number in numbersToBeSeparated)
            {
                if (number % 1m == 0m)
                {
                    numberSetWithZeroFractions[index1] = number;
                    index1++;
                }
                else
                {
                    numberSetWithNonZeroFractions[index2] = number;
                    index2++;
                }
            }

            ConsoleWriter.PrintMinMaxSumAndAverageOfArray(
                numberSetWithNonZeroFractions);
            ConsoleWriter.PrintMinMaxSumAndAverageOfArray(
                numberSetWithZeroFractions);
        }
    }
}
