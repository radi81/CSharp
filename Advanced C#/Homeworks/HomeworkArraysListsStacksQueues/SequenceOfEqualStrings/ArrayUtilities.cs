namespace SequenceOfEqualStrings
{
    using System;
    using System.Linq;

    public class ArrayUtilities
    {
        public static string[] ReadArray()
        {
            string inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
            {
                Console.WriteLine("There are no strings entered.");
                throw new ArgumentNullException(inputLine);
            }

            string[] inputStrings = inputLine.Split(' ').ToArray();

            return inputStrings;
        }

        public static void PrintSequencesOfEqualElements(string[] elements)
        {
            var distinctElements = elements.Distinct().ToArray();

            for (int i = 0; i < distinctElements.Count(); i++)
            {
                var countOfEqualElements = 0;

                for (int j = 0; j < elements.Length; j++)
                {
                    if (distinctElements[i] == elements[j])
                    {
                        countOfEqualElements++;
                    }
                }
                
                string[] arrayOfEqualStrings = new string[countOfEqualElements];

                for (int j = 0; j < arrayOfEqualStrings.Length; j++)
                {
                    arrayOfEqualStrings[j] = distinctElements[i];
                }

                Console.WriteLine(string.Join(" ", arrayOfEqualStrings));
            }
        }
    }
}