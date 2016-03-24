namespace MaximalSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public class Demo
    {
        public static void Main(string[] args)
        {
            var maximalSquareDimension = 3;
            var matrix = ReadRectangularIntMatrix();
            var maximalSquare = FindSquareWithMaxElementsSum(matrix, maximalSquareDimension);

            Console.WriteLine("Sum = {0}", FindMaxSquareSum(maximalSquare));
            PrintMaxSquare(maximalSquare);
        }

        public static int[,] ReadRectangularIntMatrix()
        {
            string inputLine = Console.ReadLine();
            
            int[] matrixDimensions = new int[2];
            try
            {
                matrixDimensions = inputLine.Split(' ').Select(int.Parse).ToArray();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Dimensions can not be null or empty.");
                throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter two valid dimensions");
                throw;
            }

            int[,] matrix = new int[matrixDimensions[0], matrixDimensions[1]];
           
            try
            {
                for (int row = 0; row < matrixDimensions[0]; row++)
                {
                    int[] inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    for (int column = 0; column < matrixDimensions[1]; column++)
                    {
                        matrix[row, column] = inputNumbers[column];
                    }
                }
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Matrix can not be null or empty.");
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Dimensions of matrix is out of range.");
                throw;
            }
            catch (FormatException)
            {
                Console.WriteLine("Integers entered are not valid.");
                throw;
            }

            return matrix;
        }

        public static int[,] FindSquareWithMaxElementsSum(
            int[,] matrix, 
            int maximalSquareDimension)
        {
            if (maximalSquareDimension > matrix.GetLength(0))
            {
                throw new ArgumentOutOfRangeException(
                    "Maximal square dimension can not be greater than matrix dimension.");
            }

            int maxSum = int.MinValue; 
            int[,] maximalSquare = new int[maximalSquareDimension, maximalSquareDimension];  

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + 
                        matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                        matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maximalSquare = new int[,] 
                        {
                            { matrix[i, j], matrix[i, j + 1], matrix[i, j + 2] },
                            { matrix[i + 1, j], matrix[i + 1, j + 1], matrix[i + 1, j + 2] },
                            { matrix[i + 2, j], matrix[i + 2, j + 1], matrix[i + 2, j + 2] }
                        };
                    }
                }
            }

            Console.WriteLine();

            return maximalSquare;
        }s

        public static int FindMaxSquareSum(int[,] maximalSquare)
        {
            int maxSquareSum = 0;
           
            for (int i = 0; i < maximalSquare.GetLength(0); i++)
            {
                for (int j = 0; j < maximalSquare.GetLength(1); j++)
                {
                    maxSquareSum += maximalSquare[i, j];
                }
            }

            return maxSquareSum;
        }

        public static void PrintMaxSquare(int[,] maximalSquare)
        {
            for (int i = 0; i < maximalSquare.GetLength(0); i++)
            {
                for (int j = 0; j < maximalSquare.GetLength(1); j++)
                {
                    Console.Write("{0} ", maximalSquare[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
