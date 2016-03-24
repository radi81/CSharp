namespace SubsetSums
{
    using LongestIncreasingSequence;

    public class SubsetSumDemo
    {
        static void Main(string[] args)
        {
            var sum = ConsoleReader.ReadNumber();
            var numbers = ConsoleReader.ConsoleReadNumbers();
            SubsetSum.PrintSubsetsWithAGivenSum(sum, numbers);
        }
    }
}
