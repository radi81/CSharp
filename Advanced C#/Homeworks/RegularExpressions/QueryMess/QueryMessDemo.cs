namespace QueryMess
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class QueryMessDemo
    {
        public static void Main(string[] args)
        {
            List<string> inputLines = EnterInputText();

            ExtractWhiteSpacesFromText(inputLines);

            var keyValuePairs = new Dictionary<string, List<string>>();

            string keyPattern = @"((?<=\?|^|\s|&)\w.*?(?=\=))";
            Regex regexKey = new Regex(keyPattern);

            string valuePattern = @"((?<==)[^&].*?(?=&|\n))";
            Regex regexValue = new Regex(valuePattern);

            for (int i = 0; i < inputLines.Count; i++)
            {
                if (regexKey.IsMatch(inputLines[i]))
                {
                    MatchCollection currentKeyMatches = regexKey.Matches(inputLines[i]);
                    List<string> currentKeys = new List<string>();
                    MatchCollection currentValueMatches = regexValue.Matches(inputLines[i]);
                    List<string> currentValues = new List<string>();

                    for (int j = 0; j < Math.Max(currentKeyMatches.Count, currentValueMatches.Count); j++)
                    {
                        currentKeys.Add(currentKeyMatches[j].Groups[1].Value);
                        currentValues.Add(currentValueMatches[j].Groups[1].Value);
                    }

                    for (int j = 0; j < currentKeys.Count - 1; j++)
                    {
                        List<string> currentValuesGroup = null;
                        currentValuesGroup.Add(currentValues[j]);
                        if (currentKeys[j] == currentKeys[j + 1])
                        {
                            currentValuesGroup.Add(currentValues[j + 1]);
                            continue;
                        }

                        keyValuePairs.Add(currentKeys[j], currentValuesGroup);
                    }
                }             
            }

            foreach (var keyValuePair in keyValuePairs)
            {
                Console.WriteLine(
                    "{0}=[{1}]",
                    keyValuePair.Key,
                    string.Join(", ", keyValuePair.Value));
            }
        }
   
        private static void ExtractWhiteSpacesFromText(List<string> inputLines)
        {
            for (int i = 0; i < inputLines.Count; i++)
            {
                Regex.Replace(inputLines[i], @"\?", "\n");
                Regex.Replace(inputLines[i], @"(\+{1,}%20{1,})", string.Empty);
                Regex.Replace(inputLines[i], @"\+", string.Empty);
                Regex.Replace(inputLines[i], @"%20", string.Empty);
                Regex.Replace(inputLines[i], @"\s+", " ");
            }
        }

        private static List<string> EnterInputText()
        {
            string inputLine = Console.ReadLine();
            List<StringBuilder> inputLines = new List<StringBuilder>();
            StringBuilder line = new StringBuilder();
            line.Append(inputLine);

            while (inputLine != "END")
            {
                inputLines.Add(line);
                inputLine = Console.ReadLine();
            }
            
            List<string> lines = new List<string>(inputLines.Count);
            for (int i = 0; i < inputLines.Count; i++)
            {
                lines.Add(inputLines[i].ToString());
            }

            return lines;
        }
    }
}
