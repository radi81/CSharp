namespace _11.LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LogsAggregatorEx
    {
        public static void Main(string[] args)
        {
            int countOfOrderLines = int.Parse(Console.ReadLine());
            int counter = 0;
            string input = Console.ReadLine();
            SortedDictionary<string, SortedDictionary<string, int>> durationOfSessionsByIPandUsers =
                new SortedDictionary<string, SortedDictionary<string, int>>();

            while (counter < countOfOrderLines)
            {
                string[] inputData = input.Trim().Split(' ');
                string IP = inputData[0];
                string user = inputData[1];
                int duration = int.Parse(inputData[2]);

                if (!durationOfSessionsByIPandUsers.ContainsKey(user))
                {
                    durationOfSessionsByIPandUsers.Add(user, new SortedDictionary<string, int>());
                }

                if (!durationOfSessionsByIPandUsers[user].ContainsKey(IP))
                {
                    durationOfSessionsByIPandUsers[user].Add(IP, duration);
                }
                else
                {
                    durationOfSessionsByIPandUsers[user][IP] += duration;
                }
                    
                input = Console.ReadLine();
                counter++;
            }

            foreach (var outerPair in durationOfSessionsByIPandUsers)
            {
                int totalDuartion = 0;             
                foreach (var innerPair in outerPair.Value)
                {
                    totalDuartion += innerPair.Value;
                }

                Console.Write("{0}: {1} ", outerPair.Key, totalDuartion);
                Console.WriteLine("[{0}]", string.Join(", ", outerPair.Value.Select(x => $"{x.Key}")));
            }
        }
    }
}
