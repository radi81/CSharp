namespace BasicStackOperations
{
    using System;
    using System.Collections.Generic; 

    public class Demo
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int amountOfElementsToPushOntoTheStack = int.Parse(input[0]);
            int amountOfIntegersToPopFromTheStack = int.Parse(input[1]);
            int elementToCheck = int.Parse(input[2]);

            string inputText = Console.ReadLine();
            string[] numbers = inputText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = Array.ConvertAll(numbers, int.Parse);
            Stack<int> stackOfElements = new Stack<int>();

            for (int i = 0; i < amountOfElementsToPushOntoTheStack; i++)
            {
                stackOfElements.Push(integers[i]);
            }

            if (amountOfElementsToPushOntoTheStack > amountOfIntegersToPopFromTheStack)
            {
                for (int i = 0; i < amountOfIntegersToPopFromTheStack; i++)
                {
                    stackOfElements.Pop();
                }

                if (stackOfElements.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minElement = stackOfElements.Pop();
                    for (int i = 0; i < stackOfElements.Count; i++)
                    {
                        int nextElement = stackOfElements.Pop();
                        if (nextElement < minElement)
                        {
                            minElement = nextElement;
                        }
                    }

                    Console.WriteLine(minElement);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
