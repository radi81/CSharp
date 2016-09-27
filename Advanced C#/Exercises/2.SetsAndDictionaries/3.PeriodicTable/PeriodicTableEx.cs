namespace _3.PeriodicTable
{
    using System;
    using System.Collections.Generic;

    public class PeriodicTableEx
    {
        public static void Main(string[] args)
        {
            int givenNumberOfChemicalCompounds = int.Parse(Console.ReadLine());
            SortedSet<string> sortedUniqueChemicalElements= new SortedSet<string>();
            string[] input = null;

            int counter = 0;
            while(counter < givenNumberOfChemicalCompounds)
            {
                input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //sortedUniqueChemicalElements.UnionWith(input) - this is too slow!
                int counter1 = 0;
                while(counter1 < input.Length)
                {
                    sortedUniqueChemicalElements.Add(input[counter1]);

                    counter1++;
                }

                counter++;
            }

            foreach (var uniqueElement in sortedUniqueChemicalElements)
            {
                Console.Write($"{uniqueElement} ");
            }
        }
    }
}
