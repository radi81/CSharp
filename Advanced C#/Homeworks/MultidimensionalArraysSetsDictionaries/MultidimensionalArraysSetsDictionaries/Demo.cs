namespace MultidimensionalArraysSetsDictionaries
{
    using System;

    public class Demo
    {
        public static void Main(string[] args)
        {
            int matrixDimension = int.Parse(Console.ReadLine());
            int[,] matrixTopToBottom = new int[matrixDimension, matrixDimension];
            PrintMatrixVerticallyTopToBottom(matrixTopToBottom);

            Console.WriteLine();

            int[,] matrixBottomToTop = new int[matrixDimension, matrixDimension];
            PrintMatrixVerticallyBottomToTop(matrixBottomToTop);
        }

        public static void PrintMatrixVerticallyTopToBottom(int[,]matrix)
        {
            int[,] inicializedMatrix = InicializeMatrixVerticallyTopToBottom(matrix);

            PrintMatrix(inicializedMatrix);
        }

        private static int[,] InicializeMatrixVerticallyTopToBottom(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 1 + i + (j * matrix.GetLength(1));
                }
            }

            return matrix;
        }

        public static void PrintMatrixVerticallyBottomToTop(int[,] matrix)
        {
            int[,] inicializedMatrix = InicializeMatrixVerticallyBottomToTop(matrix);

            PrintMatrix(inicializedMatrix);
        }

        private static int[,] InicializeMatrixVerticallyBottomToTop(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = 1 + i + (j * matrix.GetLength(1));
                    }
                    else
                    {
                        matrix[i, j] = ((j + 1) * matrix.GetLength(1)) - i;
                    }
                }
            }

            return matrix;
        }

        private static void PrintMatrix(int[,] inicializedMatrix)
        {
            for (int i = 0; i < inicializedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < inicializedMatrix.GetLength(1); j++)
                {
                    Console.Write(inicializedMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }    
    }
}
