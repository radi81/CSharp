namespace MatrixShuffling
{
    using System;

    public class Demo
    {
        public static void Main(string[] args)
        {
            int rowNumber = int.Parse(Console.ReadLine());
            int columnNumber = int.Parse(Console.ReadLine());
            var matrix = ReadMatrix(rowNumber, columnNumber);
            string inputCommand = Console.ReadLine();

            while (inputCommand != "END")
            {
                string[] inputCommandArgs = inputCommand.Split(' ');
                bool commandIsValid = ValidateCommand(inputCommandArgs, matrix);
                
                if (commandIsValid)
                {
                    SwapMatrixValues(inputCommandArgs, matrix);
                    PrintResultMatrix(matrix);
                }
                
                inputCommand = Console.ReadLine();
            }
        }

        public static string[,] ReadMatrix(int rowNumber, int columnNumber)
        {
            string[,] matrix = new string[rowNumber, columnNumber];

            for (int i = 0; i < rowNumber; i++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            return matrix;
        }

        public static bool ValidateCommand(string[] commandArgs, string[,] matrix)
        {
            bool coordinatesExists = false;
            bool isValid = true;
            bool firstCoordinatesExists = false;
            bool secondCoordinatesExists = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == int.Parse(commandArgs[1]) && col == int.Parse(commandArgs[2]))
                    { 
                        firstCoordinatesExists = true;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == int.Parse(commandArgs[3]) && col == int.Parse(commandArgs[4]))
                    {
                        secondCoordinatesExists = true;
                    }
                }
            }

            coordinatesExists = firstCoordinatesExists && secondCoordinatesExists;

            if (commandArgs[0] != "swap" ||
                commandArgs.Length != 5 ||
                !coordinatesExists)
            {
                Console.WriteLine("Invalid input!");
                isValid = false;
            }

            if (!coordinatesExists)
            {
                isValid = false;
            }

            return isValid;
        }

        public static void SwapMatrixValues(string[] inputCommandArgs, string[,] matrix)
        {
            int coordinateRow1 = 0;
            int coordinateCol1 = 0;
            int coordinateRow2 = 0;
            int coordinateCol2 = 0;
            try
            {
                coordinateRow1 = int.Parse(inputCommandArgs[1]);
                coordinateCol1 = int.Parse(inputCommandArgs[2]);
                coordinateRow2 = int.Parse(inputCommandArgs[3]);
                coordinateCol2 = int.Parse(inputCommandArgs[4]);
            }
            catch (Exception)
            {
            }

            try
            {
                string currentSwapValue = matrix[coordinateRow1, coordinateCol1];
                matrix[coordinateRow1, coordinateCol1] = matrix[coordinateRow2, coordinateCol2];
                matrix[coordinateRow2, coordinateCol2] = currentSwapValue;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public static void PrintResultMatrix(string[,] resultMatrix)
        {
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", resultMatrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
