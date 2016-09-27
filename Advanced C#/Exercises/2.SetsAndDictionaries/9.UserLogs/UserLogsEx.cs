namespace _9.UserLogs
{
    using System;
    using System.Collections.Generic;

    public class UserLogsEx
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> logsByUser = 
                new SortedDictionary<string, Dictionary<string, int>>();

            while(input != "end")
            {
                string[] stringSeparators = new string[] { "IP=", " message=", "user=" };
                string[] data = input.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                string userName = data[2];
                string IP = data[0];

                if (!logsByUser.ContainsKey(userName))
                {
                    logsByUser.Add(userName, new Dictionary<string, int>());
                }

                if(!logsByUser[userName].ContainsKey(IP))
                {
                    logsByUser[userName].Add(IP, 0);
                }              

                logsByUser[userName][IP]++;

                input = Console.ReadLine();
            }

            foreach(var outerPair in logsByUser)
            {
                Console.WriteLine("{0}: ", outerPair.Key);

                int counter = 1;
                foreach (var innerPair in outerPair.Value)
                {
                    if(counter < outerPair.Value.Count)
                    {
                        Console.Write(string.Format("{0} => {1}, ", innerPair.Key, innerPair.Value));

                        counter++;
                    }
                    else
                    {
                        Console.Write(string.Format("{0} => {1}. ", innerPair.Key, innerPair.Value));
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
