namespace StringLength
{
    using System;

    public class StringLengthDemo
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            string outputText = null;

            if (inputText.Length < 20)
            {
                string textToConcatenateWith = new string('*', 20 - inputText.Length);
                outputText = string.Concat(inputText, textToConcatenateWith);
            }
            else
            {
                outputText = inputText.Remove(20);
            }

            Console.WriteLine(outputText);
        }
    }
}
