namespace ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmailsDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var extractedEmails = ExtractEmailsFromAText(inputText);
            Console.WriteLine();
            foreach (var email in extractedEmails)
            {
                Console.WriteLine(email);
            }
        }

        private static MatchCollection ExtractEmailsFromAText(string inputText)
        {
            string pattern = @"(?<=\s)(?<user>[a-z|0-9]+[\.\-_]?[a-z|0-9]+)@"
                             + @"(?<host>([a-z]+-?[a-z]+)(\.([a-z]+-?[a-z]+))+)(?<![\W])";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(inputText);
            return matches;
        }
    }
}
