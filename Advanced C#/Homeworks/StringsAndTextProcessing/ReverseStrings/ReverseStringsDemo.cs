namespace ReverseStrings
{
    using System;
    using System.Linq;

    public class ReverseStringsDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            char[] outputText = null;

            outputText = inputText.Reverse().ToArray();

            Console.WriteLine(string.Join("", outputText));
        }
    }
}
