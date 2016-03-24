using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string firstList = Console.ReadLine();
        List<int> first = new List<int>(firstList.Split(' ')
            .Select(Int32.Parse)
            .ToList());
        string secondList = Console.ReadLine();
        List<int> second = new List<int>(secondList.Split(' ')
            .Select(Int32.Parse)
            .ToList());

        List<int> unionList = new List<int>();
        unionList.AddRange(first);
        unionList.AddRange(second);
        unionList.Sort();
        int index = 0;
        while (index < unionList.Count - 1)
        {
            if (unionList[index] == unionList[index + 1])
            {
                unionList.RemoveAt(index);
            }
            else
            {
                index++;
            }
        }
        foreach (var number in unionList)
        {
            Console.Write(number + " ");
        }
    }
}

