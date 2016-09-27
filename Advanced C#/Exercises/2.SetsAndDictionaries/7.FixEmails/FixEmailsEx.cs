namespace _7.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FixEmailsEx
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string email = Console.ReadLine();
            Dictionary<string, string> contacts = new Dictionary<string, string>();

            while(name != "stop")
            {
                if(email.ElementAt(email.Length - 2) != 'u' &&
                    email.ElementAt(email.Length - 1) != 's' && email.ElementAt(email.Length - 1) != 'c')
                {
                    contacts[name] = email;
                }

                name = Console.ReadLine();
                email = Console.ReadLine();
            }

            foreach (var kvp in contacts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
