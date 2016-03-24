namespace SortArrayOfNumbers
{
    public class SortArrayDemo
    {
        public static void Main(string[] args)
        {
            double[] arrayOfInputNumbers = ArrayUtilities.ReadAnArrayOfNumbers();
            ArrayUtilities.SortArrayOfInputNumbers(arrayOfInputNumbers);
            ArrayUtilities.PrintNumbersOnTheConsole(arrayOfInputNumbers);
        }
    }
}
