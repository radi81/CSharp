namespace _4.CountSymbols
{
    using System;
    using System.Collections.Generic;

    public class CountSymbolsEx
    {
        public static void Main(string[] args)
        {
            char[] characters = Console.ReadLine().ToCharArray();
            SortedDictionary<char, int> sortedUniqueCharacters = new SortedDictionary<char, int>();

            for (int i = 0; i < characters.Length; i++)
            {
                char currentCharacter = characters[i];

                if(!sortedUniqueCharacters.ContainsKey(currentCharacter))
                {
                    sortedUniqueCharacters[currentCharacter] = 0;
                }

                sortedUniqueCharacters[currentCharacter]++;
            }

            foreach(var kvp in sortedUniqueCharacters)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
