namespace SetsOfElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetsOfElementsEx
    {
        public static void Main(string[] args)
        {
            HashSet<int> hashSet1 = new HashSet<int>();
            HashSet<int> hashSet2 = new HashSet<int>();
            string[] lengths = 
                Console.ReadLine().Trim().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int lengthOfFirstHashSet = int.Parse(lengths[0]);
            int lengthOfSecondHashSet = int.Parse(lengths[1]);

            int counter1 = 0;
            while(counter1 < lengthOfFirstHashSet)
            {
                hashSet1.Add(int.Parse(Console.ReadLine()));

                counter1++;
            }

            int counter2 = 0;
            while(counter2 < lengthOfSecondHashSet)
            {
                hashSet2.Add(int.Parse(Console.ReadLine()));

                counter2++;
            }

            HashSet<int> repeatingElements = new HashSet<int>(hashSet1.Intersect(hashSet2));

            foreach(var repeatingElement in repeatingElements)
            {
                Console.Write($"{repeatingElement} ");
            }
        }
    }
}
