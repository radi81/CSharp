namespace Exercise2
{
    using System;
    using System.Collections.Generic;

    public class UniqueUsernamesEx
    {
        public static void Main(string[] args)
        {
            int numberOfUsernames = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            HashSet<string> usernames = new HashSet<string>();
            int count = 0;

            while(count < numberOfUsernames)
            {
                usernames.Add(input);

                count++;
                input = Console.ReadLine();
            }

            foreach(var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
