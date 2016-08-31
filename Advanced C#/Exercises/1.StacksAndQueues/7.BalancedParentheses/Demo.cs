namespace _7.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class Demo
    {
        public static void Main(string[] args)
        {
            char[] inputParentheses = Console.ReadLine().ToCharArray();
            Stack<char> leftParentheses = new Stack<char>();
            Queue<char> rightParentheses = new Queue<char>();
            bool areBalanced = false;

            for (int i = 0; i < inputParentheses.Length / 2; i++)
            {
                leftParentheses.Push(inputParentheses[i]);
            }

            for (int i = inputParentheses.Length / 2; i < inputParentheses.Length; i++)
            {
                rightParentheses.Enqueue(inputParentheses[i]);
            }

            for (int i = 0; i < inputParentheses.Length / 2; i++)
            {
                char currentLeftParentheses = leftParentheses.Pop();
                char currentRightParentheses = rightParentheses.Dequeue();

                //if (currentLeftParentheses > currentRightParentheses)
                //{
                //    areBalanced = false;

                //    break;
                //}

                // The pairs of brackets are close to one another int the ASCII table
                if (rightParentheses.Count != leftParentheses.Count ||
                    (Math.Abs(currentLeftParentheses - currentRightParentheses) != 1 &&
                    Math.Abs(currentLeftParentheses - currentRightParentheses) != 2))
                {
                    areBalanced = false;

                    break;
                }

                areBalanced = true;
            }

            Console.WriteLine(areBalanced ? "YES" : "NO");
        }
    }
}

