namespace SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSum
    {
        private static bool isFoundSubset = false;

        public static void PrintSubsetsWithAGivenSum(int sum, int[] numbers)
        {
            int numbersOfSubsets = (int)(Math.Pow(2, numbers.Length) - 1);
            List<int> subset = new List<int>();

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
                    Console.WriteLine(
                        "{0} = {1}",
                        string.Join(" + ", subset),
                        sum);
                }
            }

            if (isFoundSubset == false)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}
