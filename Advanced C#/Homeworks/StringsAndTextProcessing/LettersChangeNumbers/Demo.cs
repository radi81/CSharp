namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Demo
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<string> strings = new List<string>();
            if (inputLine.Contains(' '))
            {
                strings = inputLine
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
            else
            {
                strings.Add(inputLine);
            }
           
            double result = 0d;

            foreach (string @string in strings)
            {
                var firstLetter = @string.ElementAt(0);
                var lastLetter = @string[@string.Length - 1];
                uint number = uint.Parse(@string.Substring(1, @string.Length - 2));
                double midResult = 0d;

                if (firstLetter > 64d && firstLetter < 91d)
                {
                    // 64 is Unicode displacement for capitals latin letters from the beginning 
                    midResult = number / ((double)firstLetter - 64d);
                }
                else
                {
                    // 96 - Unicode displacement for loweer cases
                    midResult = number * ((double)firstLetter - 96d);
                }

                if (lastLetter > 64d && lastLetter < 91d)
                {
                    midResult = midResult - ((double)lastLetter - 64d);
                }
                else
                {
                    midResult = midResult + ((double)lastLetter - 96d);
                }

                result += midResult;
            }

            double roundedResult = Math.Round(result, 2);

            Console.WriteLine("{0:F2}", roundedResult);
        }
    }
}
