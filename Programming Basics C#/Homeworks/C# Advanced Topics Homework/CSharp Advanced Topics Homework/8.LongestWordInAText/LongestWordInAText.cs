using System;
using System.Collections.Generic;

class LongestWordInAText
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<string> text = new List<string>
            (input.Split(' ', ',', '.', '?', '!', ':'));
        int index = 0;

        while(index < text.Count - 1)
        {
            //Text may have several largest words.
            if (text[index].Length > text[index + 1].Length)
            {
                text.RemoveAt(index + 1);
            }
            else if (text[index].Length < text[index + 1].Length)
            {
                text.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }
        foreach (var largestWord in text)
        {
            Console.WriteLine(largestWord);
        }  
    }
}

