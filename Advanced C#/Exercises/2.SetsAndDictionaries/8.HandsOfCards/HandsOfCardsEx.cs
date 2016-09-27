namespace _8.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class HandsOfCardsEx
    {
        public static void Main(string[] args)
        {            
            Dictionary<string, HashSet<string>> playerDeck = new Dictionary<string, HashSet<string>>();
            string input = Console.ReadLine();
            string[] data = Regex.Split(input, @": ");
            string player = data[0];
            string[] cards = Regex.Split(data[1], @", ");
            HashSet<string> deck = new HashSet<string>(cards);
            
            while(input != "JOKER")
            {
                if(!playerDeck.ContainsKey(player))
                {
                    playerDeck[player] = deck;
                }
                else
                {
                    foreach (var card in deck)
                    {
                        playerDeck[player].Add(card);
                    }                    
                }

                input = Console.ReadLine();
                if(input != "JOKER")
                {
                    data = Regex.Split(input, @": ");
                    player = data[0];
                    cards = Regex.Split(data[1], @", ");
                    deck = new HashSet<string>(cards);
                }               
            }
            
            foreach (var kvp in playerDeck)
            {
                int totalValue = 0;
                int powerOfTheCardInt = 0;
                int typeOfTheCardInt = 0;

                foreach (var card in kvp.Value)
                {
                    string powerOfTheCard = card.Remove(card.Length - 1);
                    char typeOfTheCard = card[card.Length - 1];

                    switch (powerOfTheCard)
                    {
                        case "2":
                            powerOfTheCardInt = 2;
                            break;
                        case "3":
                            powerOfTheCardInt = 3;
                            break;
                        case "4":
                            powerOfTheCardInt = 4;
                            break;
                        case "5":
                            powerOfTheCardInt = 5;
                            break;
                        case "6":
                            powerOfTheCardInt = 6;
                            break;
                        case "7":
                            powerOfTheCardInt = 7;
                            break;
                        case "8":
                            powerOfTheCardInt = 8;
                            break;
                        case "9":
                            powerOfTheCardInt = 9;
                            break;
                        case "10":
                            powerOfTheCardInt = 10;
                            break;
                        case "J":
                            powerOfTheCardInt = 11;
                            break;
                        case "Q":
                            powerOfTheCardInt = 12;
                            break;
                        case "K":
                            powerOfTheCardInt = 13;
                            break;
                        case "A":
                            powerOfTheCardInt = 14;
                            break;
                    }

                    switch (typeOfTheCard)
                    {
                        case 'S':
                            typeOfTheCardInt = 4;
                            break;
                        case 'H':
                            typeOfTheCardInt = 3;
                            break;
                        case 'D':
                            typeOfTheCardInt = 2;
                            break;
                        case 'C':
                            typeOfTheCardInt = 1;
                            break;
                    }

                    totalValue += powerOfTheCardInt * typeOfTheCardInt;
                }

                Console.WriteLine("{0}: {1}", kvp.Key, totalValue);
            }           
        }
    }
}
