namespace SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSum
    {
        private static bool isFoundSubset = false;

        public static List<List<int>> CollectAllSubsetSums(int sum, int[] numbers)
        {
            int numbersOfSubsets = (int)(Math.Pow(2, numbers.Length) - 1);
            List<int> subset = new List<int>();
            List<List<int>> subsetsums = new List<List<int>>();

            for (int i = 1; i <= numbersOfSubsets; i++)
            {
                subset.Clear();

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (((i >> j) & 1) == 1)
                    {
                        subset.Add(numbers[j]);
                    }
                }

                if (subset.Sum() == sum)
                {
                    isFoundSubset = true;
                    subsetsums.Add(subset);
                    //Console.WriteLine(
                    //    "{0} = {1}",
                    //    string.Join(" + ", subset),
                    //    sum);          
                }
            }

            return subsetsums;
        }

        //public static List<int> SortSubsets(List<List<int>> subsetSums)
        //{
        //    var sortedSubsets = subsetSums.OrderBy(x => x.Count).ThenBy(s => s[0]);


        //    return sortedSubsets;
        //}

        public static void PrintSortedSubsets(List<List<int>> sortedSubsets)
        {
            foreach (var subset in sortedSubsets)
            {
                Console.WriteLine(
                    "{0} = {1}",
                    string.Join(" + ", subset),
                    subset.Sum());
            }
        }
    }
}
