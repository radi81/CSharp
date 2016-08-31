namespace _3.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Demo
    {
        public static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());
            string currentQuery;
            int newNumber = 0;
            Stack<int> stackOfElements = new Stack<int>();
            int maxElement = Int32.MinValue;
            int count = 0;
            List<int> maxElements = new List<int>();
            maxElements.Add(maxElement);

            while (count < numberOfQueries)
            {
                currentQuery = Console.ReadLine();
                if (currentQuery[0] == '1')
                {
                    newNumber = int.Parse(currentQuery.Split(new[] { ' ' }).Last());

                    if (newNumber > maxElement)
                    {
                        maxElement = newNumber;
                        maxElements.Add(maxElement);
                    }

                    stackOfElements.Push(newNumber);
                } 
                else if (currentQuery[0] == '2')
                {
                    if (maxElements.Count > 1 && 
                        stackOfElements.Peek() == maxElements.Last())
                    {
                        maxElements.RemoveAt(maxElements.Count - 1);
                        maxElement = maxElements[maxElements.Count - 1];
                    }

                        stackOfElements.Pop();
                }
                else if (currentQuery[0] == '3' &&
                    maxElements.Count != 0)
                {
                    Console.WriteLine(maxElements.Last());
                }

                count++;
            }
        }
    }
}
