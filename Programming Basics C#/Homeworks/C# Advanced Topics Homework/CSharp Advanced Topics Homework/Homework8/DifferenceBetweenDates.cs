using System;

    class DifferenceBetweenDates
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime first = DateTime.Parse(firstDate);
            DateTime second = DateTime.Parse(secondDate);
            Console.WriteLine((second.Date - first.Date).TotalDays);
        }
    }

