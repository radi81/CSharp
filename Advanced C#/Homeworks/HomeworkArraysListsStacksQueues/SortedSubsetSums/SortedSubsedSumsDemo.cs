namespace SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LongestIncreasingSequence;

    public class SubsetSumDemo
    {
        static void Main(string[] args)
        {
            var sum = ConsoleReader.ReadNumber();
            var numbers = ConsoleReader.ConsoleReadNumbers();

            var subsetSums = SubsetSum.CollectAllSubsetSums(sum, numbers);
            //var sortedSubsets = SubsetSum.SortSubsets(subsetSums);
            var sortedSubsets = subsetSums.OrderBy(x => x.Count);
            //SubsetSum.PrintSortedSubsets(sortedSubsets);
            foreach (var subset in sortedSubsets)
            {
                Console.WriteLine(
                    "{0} = {1}",
                    string.Join(" + ", subset),
                    sum);
            }

        }
    }
}
