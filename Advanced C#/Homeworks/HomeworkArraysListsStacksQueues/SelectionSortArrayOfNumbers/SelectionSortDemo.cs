namespace SortArrayOfNumbers
{
    public class SelectionSortDemo
    {
        public static void Main(string[] args)
        {
            double[] arrayOfInputNumbers = ArrayUtilities.ReadAnArrayOfNumbers();
            ArrayUtilities.SelectionSort(arrayOfInputNumbers);
            ArrayUtilities.PrintNumbersOnTheConsole(arrayOfInputNumbers);
        }
    }
}