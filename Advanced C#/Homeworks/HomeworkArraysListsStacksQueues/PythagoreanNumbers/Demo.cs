namespace PythagoreanNumbers
{
    using System;
    using System.Linq;

    public class Demo
    {
        public static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine());
            int[] integers = new int[numberOfIntegers];
            bool arePythagoreanNumbers = false;

            for (int i = 0; i < numberOfIntegers; i++)
            {
                integers[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < integers.Length; i++)
            {
                for (int j = 0; j < integers.Length; j++)
                {
                    for (int k = 0; k < integers.Length; k++)
                    {
                        int a = integers[i];
                        int b = integers[j];
                        int c = integers[k];
                        int[] positions = { i, j, k };
                        
                        if (a <= b && (a * a) + (b * b) == c * c)
                        {
                            arePythagoreanNumbers = true;
                            Console.WriteLine(
                                "{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                        }
                    }
                }
            }

            if (arePythagoreanNumbers == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
