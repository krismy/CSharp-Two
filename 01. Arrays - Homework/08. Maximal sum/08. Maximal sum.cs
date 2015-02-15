using System;
//•	Write a program that finds the sequence of maximal sum in given array.
class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        int secuence = 1;
        int[] array = new int[lenght];
        int bestSum = int.MinValue;
        int bestStartIndex = 0;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < array.Length - 1; j++)
        {
            sum += array[j];

            if (sum>bestSum)
            {
                bestSum = sum;
                bestStartIndex = j-secuence;
                ++secuence;
            }
           
        }

        Console.WriteLine("The best sequence is:");
        for (int i = bestStartIndex; i < bestStartIndex+secuence; i++)
        {
            Console.WriteLine(array[i] + " ");
        }

    }

}