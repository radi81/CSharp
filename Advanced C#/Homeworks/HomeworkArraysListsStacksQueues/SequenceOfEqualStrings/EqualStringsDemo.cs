namespace SequenceOfEqualStrings
{
    public class EqualStringsDemo
    {
        static void Main(string[] args)
        {
            var stringArray = ArrayUtilities.ReadArray();
            ArrayUtilities.PrintSequencesOfEqualElements(stringArray);
        }
    }
}
