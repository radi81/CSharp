namespace SortArrayOfNumbers
{
    using System;
    using System.Linq;

    public static class ArrayUtilities
    {
        public static double[] ReadAnArrayOfNumbers()
        {
            Console.Write("Enter numbers separated by a space: ");
            string consoleInputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(consoleInputLine))
            {
                throw new ArgumentNullException(consoleInputLine);
            }

            string[] arrayOfInputStrings = consoleInputLine.Split(' ');
            double[] arrayOfInputNumbers = null;
            try
            {
                arrayOfInputNumbers = arrayOfInputStrings
                .Select(double.Parse)
                .ToArray();
            }
            catch (FormatException)
            {
                Console.WriteLine("You have to enter valid doubles, separated by a space.");
                throw;
            }

            return arrayOfInputNumbers;
        }

        public static void SelectionSort(double[] arrayOfInputNumbers)
        {
            for (int currentIndex = 0; currentIndex < arrayOfInputNumbers.Length - 1; currentIndex++)
            {
                for (int index = currentIndex + 1; index < arrayOfInputNumbers.Length; index++)
                {
                    // Swaps current number and any of numbers at the right side if current number is larger.
                    if (arrayOfInputNumbers[currentIndex] > arrayOfInputNumbers[index])
                    {
                        SwapNumbers(
                            ref arrayOfInputNumbers[currentIndex],
                            ref arrayOfInputNumbers[index]);
                    }
                }
            }
        }

        public static void PrintNumbersOnTheConsole(double[] arrayOfInputNumbers)
        {
            Console.WriteLine(string.Join(" ", arrayOfInputNumbers));
        }

        private static void SwapNumbers(ref double firstNumber,ref double secondNumber)
        {
            double smallerNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = smallerNumber;
        }
    }
}
