
using System;
/* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
            of several neighbour elements located on the same line, column or diagonal.
          • Write a program that finds the longest sequence of equal strings in the matrix.*/

class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter number N rows: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number M columns: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        //string[,] matrix = new string[3, 4] 
        //                {
        //                { "tt", "hh", "hh", "hh" },
        //                { "lll", "tt", "d", "pp" },
        //                { "xxx", "ho", "ha", "qq" }
        //                };

        string longestSeqElement = "";
        int count = 1;
        int countMax = 0;
               
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Emter matrix element [{0},{1}]: ", row, col);
                matrix[row, col] = Console.ReadLine();

            }
        }
        //by row
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                if (count >= countMax)
                {
                    countMax = count;
                    longestSeqElement = matrix[row, col];
                }
            }
            count = 1;
        }
        //by col
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                }
                if (count >= countMax)
                {
                    countMax = count;
                    longestSeqElement = matrix[row, col];
                }
            }
            count = 1;
        }
        //by diagonals ++
        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            if (count >= countMax)
            {
                countMax = count;
                longestSeqElement = matrix[row, col];
            }
            else
            {
                count=1;
            }

        }
        //by diagonals --
        for (int row = 0, col = matrix.GetLength(1) - 1; row < (matrix.GetLength(0) - 1) && (col > 0); row++, col--)
        {
            if (matrix[row, col] == matrix[row + 1, col - 1])
            {
                count++;
            }
            if (count >= countMax)
            {
                countMax = count;
                longestSeqElement = matrix[row, col];
            }
            else
            {
                count = 1;
            }
        }
       
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]+ " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < countMax; i++)
        {
            Console.Write(longestSeqElement+ " ");
        }
        Console.WriteLine();
    }
}



//using System;
///* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
//          of several neighbour elements located on the same line, column or diagonal.
//        • Write a program that finds the longest sequence of equal strings in the matrix.*/

//class SequenceNMatrix
//{
//    static void Main()
//    {
//        Console.Write("Enter number of matrix rows: ");
//        int n = int.Parse(Console.ReadLine());
//        Console.Write("Enter number of matrix columns: ");
//        int m = int.Parse(Console.ReadLine());
//        string[,] matrix = new string[n, m];
//        //double bestSum = double.MinValue;
//        //double sum = 0;
//        //int bestRow = 0;
//        //int bestCol = 0;

//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write("Enter element [{0}, {1}]:", i, j);
//                string element = Console.ReadLine();
//                matrix[i, j] = element;
//            }
//        }
//        string longestSeqString = "";
//        int count = 1;
//        int maxcount = 0;
//        //max seq by row
//        for (int row = 0, int col = row+1; row < matrix.GetLength(0), col < matrix.GetLength(1); row++, col++)
//        {
//            //for (int col = row+1; col < matrix.GetLength(1); col++)
//            //{
//                if (matrix[row,col]==matrix[row,col+1])
//                {
//                    ++count;
//                    if (count>maxcount)
//                    {
//                        maxcount = count;
//                        int temp1 = maxcount;
//                    }
//                }
//                else
//                {
//                    count = 1;
//                }
//            //}
//        }
//        // max seq by col
//        for (int col = 0; col < matrix.GetLength(1); col++)
//        {
//            for (int row = 0; row < matrix.GetLength(0); row++)
//            {
//                if (matrix[row, col] == matrix[row, col + 1])
//                {
//                    ++count;
//                    if (count > maxcount)
//                    {
//                        maxcount = count;
//                        int temp2 = maxcount;
//                    }
//                }
//                else
//                {
//                    count = 1;
//                }
//            }
//        }
//        // for diagonals
//        for (int col = 0; col < matrix.GetLength(1); col++)
//        {
//            for (int row = 0; row < matrix.GetLength(0); row++)
//            {
//                if (matrix[row, col] == matrix[row, col + 1])
//                {
//                    ++count;
//                    if (count > maxcount)
//                    {
//                        maxcount = count;
//                        int temp3 = maxcount;
//                    }
//                }
//                else
//                {
//                    count = 1;
//                }
//            }
//        }
//    }
//}

