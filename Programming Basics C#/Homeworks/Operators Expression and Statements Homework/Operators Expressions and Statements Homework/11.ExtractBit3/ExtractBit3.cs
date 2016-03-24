using System;

    class ExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("This program extract the value of the bit #3 " +
                "of a given unsigned integer.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int bitAtPossition3 = 1;

            if ((1 & (n >> 3)) == 0)
            {
                bitAtPossition3 = 0;
            }
            Console.WriteLine("bit #3 -> {0}", bitAtPossition3);
        }
    }

