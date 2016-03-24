namespace SequenceInMatrix
{
    using System;
    using System.Collections.Generic;
    
    public class SequenceMatrixDemo
    {
        public static void Main(string[] args)
        {
            int matrixHeight = int.Parse(Console.ReadLine());
            int matrixWidth = int.Parse(Console.ReadLine());
            string[,] matrix = ReadMatrix(matrixHeight, matrixWidth);

            string[] longestSequence = FindLongestSequence(matrix);
            PrintLongestSequence(longestSequence);
        }
        
        public static string[] FindLongestSequence(string[,] matrix)
        {
            var longestSequenceOnLine = FindLongestSequenceOnLine(matrix);
            var longestSequenceOnColumn = FindLongestSequenceOnColumn(matrix);
            var longestSequenceOnDiagonal = FindLongestSequenceOnDiagonal(matrix);
            List<string[]> sequences = new List<string[]>();

            sequences.Add(longestSequenceOnLine);
            sequences.Add(longestSequenceOnColumn);
            sequences.Add(longestSequenceOnDiagonal);

            int bestLength = 0;
            string bestWord = null;

            for (int i = 0; i < 3; i++)
            {
                int length = int.Parse(sequences[i][1]);
                string word = sequences[i][0];

                if (length > bestLength)
                {
                    bestLength = length;
                    bestWord = word;
                }
            }

            var longestSequence = new string[] { bestWord, bestLength.ToString() };

            return longestSequence;
        }

        private static string[] FindLongestSequenceOnLine(string[,] matrix)
        {
            int bestLength = 0;
            string bestWord = null;
            string word = null;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int length = 1;
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != matrix[i, j + 1])
                    {
                        break;
                    }

                    word = matrix[i, j];
                    length++;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestWord = word;
                }

                if (bestWord == null)
                {
                    bestWord = matrix[0, 0];
                }
            }

            var bestWordTimes = new string[] { bestWord, bestLength.ToString() };

            return bestWordTimes;
        }

        private static string[] FindLongestSequenceOnColumn(string[,] matrix)
        {
            int bestLength = 0;
            string bestWord = null;
            string word = null;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int length = 1;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j])
                    {
                        break;
                    }

                    word = matrix[i, j];
                    length++;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestWord = word;
                }

                if (bestWord == null)
                {
                    bestWord = matrix[0, 0];
                }
            }

            var bestWordTimes = new string[] { bestWord, bestLength.ToString() };

            return bestWordTimes;
        }

        private static string[] FindLongestSequenceOnDiagonal(string[,] matrix)
        {
            int bestLength = 0;
            string bestWord = null;
            string word = null;

            // Up to down
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int length = 1;
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] != matrix[i + 1, j + 1])
                    {
                        break;
                    }

                    word = matrix[i, j];
                    length++;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestWord = word;
                }

                if (bestWord == null)
                {
                    bestWord = matrix[0, 0];
                }
            }

            var bestWordTimes = new string[] { bestWord, bestLength.ToString() };

            return bestWordTimes;
        }

        public static string[,] ReadMatrix(int matrixHeight, int matrixWidth)
        {
            string[,] matrix = new string[matrixHeight, matrixWidth];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            return matrix;
        }

        public static void PrintLongestSequence(string[] longestSequence)
        {
            List<string> output = new List<string>();
            for (int i = 0; i < int.Parse(longestSequence[1]); i++)
            {
                output.Add(longestSequence[0]);
            }

            Console.WriteLine();

            Console.Write(string.Join(", ", output));
        }
    }
}
