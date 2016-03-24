namespace UnicodeCharacters
{
    using System;
    using System.Text;

    public class UnicodeCharactersDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string outputText = ConvertToUnicodeCharacters(inputText);

            Console.WriteLine(outputText);
        }

        public static string ConvertToUnicodeCharacters(string text)
        {
            StringBuilder outputText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                outputText.Append("\\u");
                outputText.Append(string.Format("{0:x4}", (int)text[i]));
            }

            return outputText.ToString();
        }
    }
}
