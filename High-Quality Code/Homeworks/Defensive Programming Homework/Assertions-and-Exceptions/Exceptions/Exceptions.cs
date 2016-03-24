using System;
using System.Collections.Generic;
using System.Text;

public class Exceptions
{
    public static T[] ExtractSubsequence<T>(T[] arr, int startIndex, int count)
    {
        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (count > str.Length)
        {
            throw new ArgumentNullException(
                nameof(count),
                "Count must be greater than number of string letters.");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                throw new ArgumentException(
                    "The number is not prime!");
            }
        }
    }
}
