using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    public class ReadingNumbers
    {
        internal const int Start = 1;
        private const int End = 100;
        private const int Counter = 10;

        List<int> enteredNumbers;

        public ReadingNumbers(int number)
        {
            for (int i = 0; i < Counter; i++)
            {
                this.enteredNumbers[i] = number;
            }
        }

        public List<int> EnteredNumbers
        {
            get { return enteredNumbers; }
            set { enteredNumbers = value; }
        }

        public static int ReadNumber(string inputedNumber)
        {    
            try
            {
                int.Parse(inputedNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.Enter an integer number.");
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Number is out of range");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
                throw;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Invalid number.");
                throw;
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error has occured.");
            }

            int number = int.Parse(inputedNumber);

            if (number < ReadingNumbers.Start || number > ReadingNumbers.End)
            {
                throw new ArgumentOutOfRangeException("The number is not in range");
            }
            
            return number;
        }     
    }
}
