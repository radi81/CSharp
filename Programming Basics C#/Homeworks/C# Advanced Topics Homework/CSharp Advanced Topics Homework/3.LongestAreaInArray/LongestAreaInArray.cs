using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        string[] elements = new string[n];
        int bestLength = 1;
        string bestStart = null;
        int length = 1;
        string start;

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            elements[i] = input;
        }

          for (int i = 1; i < elements.Length; i++)
           {

            if (elements[i] == elements[i - 1])
            {
             start = elements[i - 1];
             length++;
            }
             else
            {
              start = elements[i];
              length = 1;
            }
            if (length > bestLength)
            {
             bestLength = length;
             bestStart = start;
            }
            if (bestLength == 1)
            {
                bestStart = elements[0];
            }
        }

        Console.WriteLine(bestLength);
        for (int i = 0; i < bestLength; i++)
        {
            Console.WriteLine(bestStart);
        }
    }
}

