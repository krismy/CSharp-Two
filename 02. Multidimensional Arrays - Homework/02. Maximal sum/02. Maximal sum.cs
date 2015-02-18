using System;
//•	Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter number of matrix rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of matrix columns: ");
        int m = int.Parse(Console.ReadLine());
        double[,] matrix = new double[n, m];
        double bestSum = double.MinValue;
        double sum = 0;
        int bestRow = 0;
        int bestCol = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("Enter element [{0}, {1}]:", i, j);
                double element = double.Parse(Console.ReadLine());
                matrix[i, j] = element;
            }
        }
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum>=bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("Best platform 3x3 is:");
        for (int platformRow = bestRow  ; platformRow < bestRow+3; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol+3; platformCol++)
            {
                Console.Write(matrix[platformRow,platformCol] +" ");
            }
            Console.WriteLine();
        }

    }
}

