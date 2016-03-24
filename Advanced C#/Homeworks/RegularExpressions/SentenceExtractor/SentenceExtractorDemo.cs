namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractorDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            var text = SplitSentencesInDifferentLines(inputText);

            string pattern = 
                @"[A-Z][^[\.\s)].{0,}[^\.]\bis\b.{0,}(?<=\.|!|\?)";
            var outputSentences = FindAllSentencesContainingPattern(pattern, text);

            PrintMatches(outputSentences);
        }

        private static void PrintMatches(MatchCollection outputSentences)
        {
            Console.WriteLine();
            foreach (var match in outputSentences)
            {
                Console.WriteLine(match + Environment.NewLine);
            }
        }

        private static MatchCollection FindAllSentencesContainingPattern(string pattern, string text)
        {
            Regex regex = new Regex(pattern);
            MatchCollection outputSentences = regex.Matches(text);
            return outputSentences;
        }

        private static string SplitSentencesInDifferentLines(string inputText)
        {
            // SentencesSeparator (?<=[.!?])\s+(?=[A-Z]) works correctly too.
            string sentencesSeparator = @"(?<=[\?\!\.])\s";
            string[] splittedSentences = Regex.Split(inputText, sentencesSeparator);
            string text = string.Join("\n", splittedSentences);
            return text;
        }
    }
}
