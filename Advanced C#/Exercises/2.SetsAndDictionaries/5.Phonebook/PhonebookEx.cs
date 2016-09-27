namespace _5.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class PhonebookEx
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while(input != "search")
            {
                string[] nameNumberPair = input.Trim().Split('-');
                string name = nameNumberPair[0];
                string number = nameNumberPair[1];

                contacts[name] = number;

                input = Console.ReadLine();
            }

            string nameToSearch = Console.ReadLine();

            while(nameToSearch != "stop" && nameToSearch != "Stop")
            {
                if(contacts.ContainsKey(nameToSearch))
                {
                    string phoneNumber = contacts[nameToSearch];
                    Console.WriteLine($"{nameToSearch} -> {phoneNumber}");
                }
                else
                {
                    Console.WriteLine($"Contact {nameToSearch} does not exist.");
                }

                nameToSearch = Console.ReadLine();              
            }
        }
    }
}
