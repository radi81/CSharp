namespace ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTagDemo
    {
        public static void Main(string[] args)
        {
            string htmlText = Console.ReadLine();

            var replacedText = ReplaceHTMLTagsWithURLTagsInText(htmlText);
            Console.WriteLine(replacedText);
        }

        private static string ReplaceHTMLTagsWithURLTagsInText(string htmlText)
        {
            // The input is read on a single line 
            string pattern = @"(<ul><li>)(<a)(.*)(>)(.*)(<\/a>)(<\/li><\/ul>)";
            string firstReplacementPart = "[URL";
            string secondReplacementPart = "]";
            string thirdReplacementPart = @"[/URL]";

            string urlText = Regex.Replace(
                htmlText,
                pattern,
                m =>
                m.Groups[1] + firstReplacementPart + m.Groups[3] + secondReplacementPart + m.Groups[5] + thirdReplacementPart
                + m.Groups[7]);

            string output = urlText.Replace(((char)34).ToString(), string.Empty).Replace(((char)39).ToString(), string.Empty);
            return output;
        }
    }
}
