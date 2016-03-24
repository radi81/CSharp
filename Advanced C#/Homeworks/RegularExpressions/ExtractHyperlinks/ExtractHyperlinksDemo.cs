namespace ExtractHyperlinks
{
    using System;
    using System.Collections.Generic;

    public class ExtractHyperlinksDemo
    {
        public static void Main(string[] args)
        {
            var inputLines = EnterInputHTMLCode();


        }

        private static List<string> EnterInputHTMLCode()
        {
            string inputLine = Console.ReadLine();
            List<string> inputLines = new List<string>();

            while (inputLine != "END")
            {
                inputLines.Add(inputLine);
                inputLine = Console.ReadLine();
            }

            return inputLines;
        }
    }
}
