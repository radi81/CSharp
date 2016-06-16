using System;

namespace _3.GenericList
{
    class Program
    {
        static void Main()
        {
            GenericList<int> integers = new GenericList<int>();
            integers.AddElement(3);
            integers.AddElement(1);
            integers.AddElement(0);
            integers.AddElement(6);

            Console.WriteLine("{0}", integers.AccessElement(2));
            integers.RemoveElement(0);
            integers.InsertElement(3, 1);
            Console.WriteLine(integers.ToString());
        }
    }
}
