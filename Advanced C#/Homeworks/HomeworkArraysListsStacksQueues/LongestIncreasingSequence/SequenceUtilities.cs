namespace LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceUtilities
    {
        public static void PrintAllIncreasingSequencesAndMax(int[] arrayOfIntegers)
        {
            List<int> currentSequence = new List<int>();
            List<List<int>> allSequences = new List<List<int>>();

            for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
            {
                int step = 0;

                if (currentSequence.Count == 0)
                {
                    currentSequence.Add(arrayOfIntegers[i + step]);
                }

                if (arrayOfIntegers[i + step] < arrayOfIntegers[i + 1 + step])
                {
                    step++;
                    currentSequence.Add(arrayOfIntegers[i + 1]);
                }
                else
                {
                    Console.WriteLine(string.Join(" ", currentSequence));
                    allSequences.Add(currentSequence);
                    currentSequence.Clear();
                }

                if (arrayOfIntegers.Length - 1 == i + 1 + step &&
                        arrayOfIntegers[i + step] > arrayOfIntegers[i + 1 + step])
                {
                    Console.WriteLine(arrayOfIntegers[i + 1 + step]);
                }
            }

            if (currentSequence.Count != 0)
            {
                Console.WriteLine(string.Join(" ", currentSequence));
            }

            var longestSequenceCount = 0;
            var longestSequence = new List<int>();

            for (int index = 0; index < allSequences.Count; index++)
            {
                if (allSequences[index].Count > longestSequenceCount)
                {
                    longestSequenceCount = allSequences[index].Count;
                    longestSequence = allSequences[index];
                }
                
            }

            Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
        }
    }
}
