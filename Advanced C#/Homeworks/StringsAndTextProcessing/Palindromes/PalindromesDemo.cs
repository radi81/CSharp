namespace Palindromes
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Palindromes
    {
        public class PalindromesDemo
        {
            public static void Main()
            {
                string inputText = Console.ReadLine();

                var palindromes = Regex.Matches(inputText, @"\w+").Cast<Match>()
                        .Select(m => m.Value) 
                        .Where(w => string.Join("", w.Reverse()) == w)
                        .GroupBy(w => w)
                        .Select(g => new { g.Key })
                        .ToList();

                foreach (var palindrome in palindromes)
                {
                    Console.WriteLine(string.Join(", ", palindrome));
                }
            }
        }
    }
}
