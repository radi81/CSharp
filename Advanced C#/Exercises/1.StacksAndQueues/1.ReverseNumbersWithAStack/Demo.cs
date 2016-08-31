namespace _1.ReverseNumbersWithAStack
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = Array.ConvertAll(numbers, int.Parse);

            Stack<int> stackOfNumbers = new Stack<int>();

            foreach (var integer in integers)
            {
                stackOfNumbers.Push(integer);
            }

            int[] reversedNumbers = new int[stackOfNumbers.Count];

            for (int i = 0; i < reversedNumbers.Length; i++)
            {
                reversedNumbers[i] = stackOfNumbers.Pop();
            }

            Console.Write(string.Join(" ", reversedNumbers));
        }
    }
}
