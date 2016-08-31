namespace _9.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n));
        }

        private static long GetFibonacci(uint n)
        {
            Stack<uint> sequence = new Stack<uint>();
            sequence.Push(1);
            sequence.Push(1);
            int counter = 2;

            while (true)
            {
                if (n <= 1)
                {
                    return 1;
                }

                uint x = sequence.Pop();
                uint y = sequence.Pop();
                uint z = x + y;

                sequence.Push(y);
                sequence.Push(x);
                sequence.Push(z);

                if (counter == n)
                {
                    return sequence.Peek();
                }

                counter++;
            }
        }
    }
}
