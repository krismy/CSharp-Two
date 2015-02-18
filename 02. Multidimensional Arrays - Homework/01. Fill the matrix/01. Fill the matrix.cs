using System;
//•	Write a program that fills and prints a matrix of size (n, n) 

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter size n a matrix (n x n): ");
        int n = int.Parse(Console.ReadLine());
        double[,] matrix = new double[n,n];
        int start = 1;
        //а

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                 matrix[row,col]=start;
                 start+=n;
                 Console.Write("{0,3}",matrix[row,col]);
            }
            start = row + 2;
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");
        
        //b
        start = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = start++;
                    //Console.Write("{0,3} ", matrix[row, col]);
                }
            }
            else
            {
                
                for (int row = (matrix.GetLength(0) - 1); row >= 0; row--)
                {
                    matrix[row, col] = start++;
                    //Console.Write("{0,3} ", matrix[row, col]);
                }
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        //c
        //start = 1;
        //for (int row =  matrix.GetLength(0); row <=0; row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("{0,3} ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }
}

