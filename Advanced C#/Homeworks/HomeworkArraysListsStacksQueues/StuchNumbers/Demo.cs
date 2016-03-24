using System;
using System.Collections.Generic;

namespace StuckNumbers
{
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] numbers = ConsoleReadNumbers(number);
            bool numbersAreStuck = true;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        for (int l = 0; l < number; l++)
                        {
                            numbersAreStuck = string.Concat(numbers[i], numbers[j])
                                              == string.Concat(numbers[k], numbers[l]);

                            int[] stuckValues = { i, j, k, l };
                            bool stuckValuesAreUnique = stuckValues.Distinct().Count() == stuckValues.Length;

                            if (numbersAreStuck && stuckValuesAreUnique)
                            {
                                Console.WriteLine(
                                    "{0}|{1} = {2}|{3}", 
                                    numbers[i], 
                                    numbers[j], 
                                    numbers[k], 
                                    numbers[l]);
                            }
                            else
                            {
                                numbersAreStuck = false;
                            }
                        }
                    }
                }
            }

            if (numbersAreStuck == false)
            {
                Console.WriteLine("No");
            }
        }

        public static string[] ConsoleReadNumbers(int n)
        {
            string inputLine = Console.ReadLine();
            
            string[] inputNumbers = inputLine.Split(' ').ToArray();
         
            return inputNumbers;
        }
    }
}
