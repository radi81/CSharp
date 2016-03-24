namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../file.txt"))
            {
                using (var wordsReader = new StreamReader("../../words.txt"))
                {
                    using (var writer = new StreamWriter("../../result.txt"))
                    {
                        string[] allWordsInText = reader.ReadToEnd().Split().ToArray();
                        string word = wordsReader.ReadLine();

                        while (word != null)
                        { 
                            var wordQuery = allWordsInText.Where(w => w == word);

                            writer.Write(
                                "{0} - {1}{2}",
                                word, 
                                wordQuery.Count(), 
                                Environment.NewLine);

                            word = wordsReader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
