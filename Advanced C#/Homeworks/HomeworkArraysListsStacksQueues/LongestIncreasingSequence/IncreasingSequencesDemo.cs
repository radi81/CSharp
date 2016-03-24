namespace LongestIncreasingSequence
{
    public class IncreasingSequencesDemo
    {
        public static void Main(string[] args)
        {
            var integerNumbers = ConsoleReader.ConsoleReadNumbers();
            SequenceUtilities.PrintAllIncreasingSequencesAndMax(integerNumbers);
        }
    }
}
