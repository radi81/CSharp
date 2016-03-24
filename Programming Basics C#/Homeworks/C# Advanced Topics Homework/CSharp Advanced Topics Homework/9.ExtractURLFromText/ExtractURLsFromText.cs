using System;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    static void Main()
    {
        string text = Console.ReadLine();

        foreach (Match item in Regex.Matches(text, @"\b(?:https?://|www\.)\S+\b"))
        {
            Console.WriteLine(item.Value);
        }
    }
}

