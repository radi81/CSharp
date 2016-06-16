using System;

namespace Homework_ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a possitive integer number: ");
            string input = Console.ReadLine();
            int number = 0;

            try
            {
                uint.Parse(input);
                number = int.Parse(input);
                Console.WriteLine(SquareRoot.CalculateSquareRoot(number));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
