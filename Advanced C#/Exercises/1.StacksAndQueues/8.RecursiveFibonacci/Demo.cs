namespace _8.RecursiveFibonacci
{
    using System;

    public class Demo
    {
        public static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacci(n));
        }

        private static ulong GetFibonacci(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
