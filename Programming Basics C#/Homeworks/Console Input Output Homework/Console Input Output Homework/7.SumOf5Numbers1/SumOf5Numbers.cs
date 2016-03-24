using System;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.WriteLine("Enter 5 numbers, separated by a space: ");
            string[] input = Console.ReadLine().Split(' ');
            double firstNumber = double.Parse(input[0]);
            double secondNumber = double.Parse(input[1]);
            double thirdNumber = double.Parse(input[2]);
            double forthNumber = double.Parse(input[3]);
            double fifthNumber = double.Parse(input[4]);
            double sum = firstNumber + secondNumber + 
                thirdNumber + forthNumber + fifthNumber;
            Console.WriteLine("sum = {0}", sum);
        }
    }

