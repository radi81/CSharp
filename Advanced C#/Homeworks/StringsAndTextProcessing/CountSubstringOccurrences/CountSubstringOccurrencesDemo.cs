namespace CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrencesDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            
            Console.WriteLine(CountStringOccurrances(inputText, pattern));
        }

        public static int CountStringOccurrances(string text, string pattern)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text.Substring(i).Length >= pattern.Length)
                {
                    if (text.Substring(i, pattern.Length).Equals(pattern))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
