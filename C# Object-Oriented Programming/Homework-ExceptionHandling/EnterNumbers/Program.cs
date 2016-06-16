using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 10 integers: ");
            int counter = 0;
            int lastNumber = Int32.MinValue; ;

            while (counter < 10)
            {
                string str = Console.ReadLine();
                int num = Int32.MinValue;
                try
                {
                    ReadingNumbers.ReadNumber(str);
                    num = int.Parse(str);

                }
                catch (FormatException)
                {
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number is not in range");
                    continue;
                }

                if (num <= lastNumber
                    || num <= ReadingNumbers.Start)
                {
                    Console.WriteLine("Invalid input. Enter another number greater than previous number or min limit : ");
                }

                if (num > lastNumber
                    && num > ReadingNumbers.Start)
                {
                    lastNumber = num;
                    counter++;
                }
            }
        }
    }
}
