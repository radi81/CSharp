using System;
using System.Collections.Generic;

    class SortingNumbers
    {
        static void Main()
        {
        int numberN = Int32.Parse(Console.ReadLine());
        int counter = 0;
        List<int> numbers = new List<int>();

        while (counter < numberN)
        {
            int n = Int32.Parse(Console.ReadLine());
            numbers.Add(n);
            counter++;
        }

        numbers.Sort();
        
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        }
    }

