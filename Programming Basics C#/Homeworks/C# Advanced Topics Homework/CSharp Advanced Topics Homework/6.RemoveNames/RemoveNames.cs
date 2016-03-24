using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string firstList = Console.ReadLine();
        string secondList = Console.ReadLine();
        List<string> first = new List<string>(firstList.Split(' '));
        List<string> second = new List<string>(secondList.Split(' '));

        for (int i = 0; i < second.Count; i++)
        {
            first.RemoveAll(item => item == second[i]);
        }
        foreach(var name in first)
        {
            Console.Write(name + " ");
        }
    }
}

