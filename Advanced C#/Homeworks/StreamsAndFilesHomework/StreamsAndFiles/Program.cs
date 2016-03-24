namespace StreamsAndFiles
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("file.txt"))
            {
                int lineNumber = 1;
                string line = reader.ReadLine();

                while (line != null)
                {
                    lineNumber++;

                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                   
                    line = reader.ReadLine();
                }
            }
        }
    }
}
