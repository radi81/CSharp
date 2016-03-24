namespace LineNumbers
{
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../file.txt"))
            {
                using (var writer = new StreamWriter("../../newFile.txt"))
                {
                    var line = reader.ReadLine();
                    int lineNumber = 1;

                    while (line != null)
                    {
                        var newLine = line.Insert(0, $"{lineNumber}. ");

                        writer.WriteLine(newLine);
                        line = reader.ReadLine();
                 
                        lineNumber++;
                    }
                }
            }
        }
    }
}
