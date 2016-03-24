using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("This program extracts from given integer n " +
                "the value of given bit at index p");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            int bitAtPossitionP = 0;

            if ((1 & (n >> p)) == 1)
            {
                bitAtPossitionP = 1;
            }
            Console.WriteLine("bit @ p -> {0}", bitAtPossitionP);
        }
    }

