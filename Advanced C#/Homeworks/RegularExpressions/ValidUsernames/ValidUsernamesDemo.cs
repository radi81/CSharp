namespace ValidUsernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernamesDemo
    {
        public static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string pattern = 
                @"((?<=\b|\/|\\|\(|\))(?:[A-Za-z])\w{2,24}(?<=\b))";

            if (inputLine.Length <= 9999)
            {
                var usernames = ExtractUsernames(
                pattern,
                inputLine);

                string secondUsername;
                var firstUsername = FindTwoConsecutiveUsernamesWithBiggestSum(
                    usernames,
                    out secondUsername);

                PrintUsernamesWithBiggestSum(
                    firstUsername,
                    secondUsername);
            }
        }

        private static void PrintUsernamesWithBiggestSum(
            string firstUsername, 
            string secondUsername)
        {
            Console.WriteLine(
                Environment.NewLine + firstUsername);
            Console.WriteLine(secondUsername);
        }

        private static string FindTwoConsecutiveUsernamesWithBiggestSum(
            string[] usernames, 
            out string secondUsername)
        {
            int biggestSum = 0;
            string firstUsername = null;
            secondUsername = null;
            for (int i = 0; i < usernames.Length - 1; i++)
            {
                int sum = usernames[i].Length + usernames[i + 1].Length;
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    firstUsername = usernames[i];
                    secondUsername = usernames[i + 1];
                }
            }

            return firstUsername;
        }

        private static string[] ExtractUsernames(
            string pattern, 
            string inputLine)
        {
            Regex regex = new Regex(pattern);
            MatchCollection validUsernames = regex.Matches(inputLine);

            string[] usernames = new string[validUsernames.Count];
            for (int i = 0; i < validUsernames.Count; i++)
            {
                usernames[i] = validUsernames[i].Groups[1].Value;
            }

            return usernames;
        }
    }
}
