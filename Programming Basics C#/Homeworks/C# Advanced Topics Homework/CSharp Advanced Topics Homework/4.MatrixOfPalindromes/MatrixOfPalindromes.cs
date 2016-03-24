using System;
using System.Text;

    class MatrixOfPalindromes
    {
        static void Main()
        {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int k = 0;
        string aaa = "aaa";
        StringBuilder strbld = new StringBuilder(aaa);
        StringBuilder[,] strMatrix = new StringBuilder[row, col];

        for (int i = 0; i < strMatrix.GetLength(0); i++)
        {
            k = i;
            for (int j = 0; j < strMatrix.GetLength(1); j++)
            {
                strbld.Remove(0, 1);
                strbld.Insert(0, (char)('a' + i));
                strbld.Remove(1, 1);
                strbld.Insert(1, (char)('a' + k));
                strbld.Remove(2, 1);
                strbld.Insert(2, (char)('a' + i));
                strMatrix[i, j] = strbld;
                k++;
                Console.Write(strMatrix[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }
        }
    }

