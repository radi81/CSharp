namespace TextFilter
{
    using System;
    using System.Linq;

    public class TextFilterDemo
    {
        public static void Main(string[] args)
        {
            var bannedWords = ReadBannedWords();
            string text = Console.ReadLine();

            string outputText = ReplaceSubstrings(bannedWords, text);
            Console.WriteLine(Environment.NewLine + outputText);    
        }

        private static string[] ReadBannedWords()
        {
            string bannedWordsInput = Console.ReadLine();
            string[] bannedWords = null;
            try
            {
                 bannedWords = bannedWordsInput.Split(' ', ',').ToArray();   
            } 
            catch (NullReferenceException)
            {
                Console.WriteLine(
                    "Banned words can not be null.");
                throw;
            }

            return bannedWords;
        }

        private static string ReplaceSubstrings(string[] bannedWords, string text)
        {
            string outputText = null;
            try
            {
                for (int i = 0; i < bannedWords.Length; i++)
                {
                    if (text.Contains(bannedWords[i]) &&
                        text.Length > 0 &&
                        bannedWords[i].Length > 0)
                    {
                        int numberOfCharsToReplace = bannedWords[i].Length;
                        outputText = text.Replace(bannedWords[i], new string('*', numberOfCharsToReplace));
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Text can not be null or empty.");
                throw;
            }

            if (outputText == null)
            {
                outputText = text;
            }

            return outputText;
        }
    }
}
