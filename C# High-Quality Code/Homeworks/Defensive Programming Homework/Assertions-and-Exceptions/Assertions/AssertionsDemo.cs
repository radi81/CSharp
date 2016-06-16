namespace Assertions_Homework
{
    using System;

    public class AssertionsDemo
    {
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            SearchAlgorithms.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            // Test sorting empty array
            int[] arrayWithoutElements = new int[0] { };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arrayWithoutElements));
            //SearchAlgorithms.SelectionSort(arrayWithoutElements);
            //Console.WriteLine("sorted = [{0}]", string.Join(", ", arrayWithoutElements));
            //SearchAlgorithms.BinarySearch(arrayWithoutElements, 6);
            //Console.WriteLine("sorted = [{0}]", string.Join(", ", arrayWithoutElements));

            // Test sorting single element array
            int[] arrayWithOneElement = new int[1] { 3 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arrayWithOneElement));
            //SearchAlgorithms.SelectionSort(arrayWithOneElement);
            //Console.WriteLine("sorted = [{0}]", string.Join(", ", arrayWithOneElement));
            SearchAlgorithms.BinarySearch(arrayWithOneElement, 4);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arrayWithOneElement));

            //Console.WriteLine(BinarySearch(arr, -1000));
            Console.WriteLine(SearchAlgorithms.BinarySearch(arr, 0));
            Console.WriteLine(SearchAlgorithms.BinarySearch(arr, 17));
            //Console.WriteLine(BinarySearch(arr, 10));
            //Console.WriteLine(BinarySearch(arr, 1000));
        }
    }
}
