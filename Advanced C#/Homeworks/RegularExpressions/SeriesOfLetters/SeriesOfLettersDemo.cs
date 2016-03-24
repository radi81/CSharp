namespace SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    public class SeriesOfLettersDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string pattern = @"([a-zA-Z0-9])\1\1{0,}";
            string replacementPattern = @"$1";

            var result = ReplaceAllSeriesOfConsecutiveLetters(
                pattern, 
                inputText, 
                replacementPattern);

            Console.WriteLine(result);
        }

        private static string ReplaceAllSeriesOfConsecutiveLetters(
            string pattern, 
            string inputText, 
            string replacementPattern)
        {
            Regex regex = new Regex(pattern);
            string result = regex.Replace(inputText, replacementPattern).Trim();
            return result;
        }
    }
}
