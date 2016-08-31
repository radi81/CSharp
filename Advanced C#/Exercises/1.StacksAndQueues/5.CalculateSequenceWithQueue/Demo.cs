namespace _5.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        public static void Main(string[] args)
        {
            long currentNumber = long.Parse(Console.ReadLine());
            int numbersToPrint = 50;
            int counter = 0;
            Queue<long> sequence = new Queue<long>();
            sequence.Enqueue(currentNumber);

            while (counter < numbersToPrint)
            {
                long outputNumber = sequence.Dequeue();
                counter++;
                Console.Write("{0} ", outputNumber);
                currentNumber = outputNumber;

                long s1 = currentNumber + 1;
                sequence.Enqueue(s1);
                long s2 = (2 * currentNumber) + 1;
                sequence.Enqueue(s2);
                long s3 = currentNumber + 2;
                sequence.Enqueue(s3);
            }
        } 
    }
}
