using System;

    class CheckABitAtGivenPosition
    {
        static void Main()
        {
            Console.WriteLine("This program returns if the bit at possition " +
                "p in given integer number n has value of 1.");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("p = ");
            int p = int.Parse(Console.ReadLine());
            bool isBitAtPossitionPEqualTo1 = true;

            if (((n >> p) & 1) == 0)
            {
                isBitAtPossitionPEqualTo1 = false;
            }
            Console.WriteLine("bit @ p == 1 {0}", isBitAtPossitionPEqualTo1);
        }
    }

