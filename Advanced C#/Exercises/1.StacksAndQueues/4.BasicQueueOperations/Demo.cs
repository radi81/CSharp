using System;
using System.Collections.Generic;

namespace _4.BasicQueueOperations
{
    public class Demo
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int amountOfElementsToEnqueueInTheQueue = int.Parse(input[0]);
            int amountOfIntegersToDequeueFromTheQueue = int.Parse(input[1]);
            int elementToCheck = int.Parse(input[2]);

            string inputText = Console.ReadLine();
            string[] numbers = inputText.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = Array.ConvertAll(numbers, int.Parse);
            Queue<int> queueOfElements = new Queue<int>();

            for (int i = 0; i < amountOfElementsToEnqueueInTheQueue; i++)
            {
                queueOfElements.Enqueue(integers[i]);
            }

            if (amountOfElementsToEnqueueInTheQueue > amountOfIntegersToDequeueFromTheQueue)
            {
                for (int i = 0; i < amountOfIntegersToDequeueFromTheQueue; i++)
                {
                    queueOfElements.Dequeue();
                }

                if (queueOfElements.Contains(elementToCheck))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    int minElement = queueOfElements.Dequeue();
                    for (int i = 0; i < queueOfElements.Count; i++)
                    {
                        int nextElement = queueOfElements.Dequeue();
                        if (nextElement <= minElement)
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
