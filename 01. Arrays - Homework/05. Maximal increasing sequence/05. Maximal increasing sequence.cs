using System;
/*	Write a program that finds the maximal increasing sequence in an array.

 input 	                result
3, 2, 3, 4, 2, 2, 4 	2, 3, 4
 
 */
class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        int bestSum = 0;
        int bestIndex = 0;
        int sum = 0;
        for (int i = 0; i < lenght; i++)
        {
            Console.WriteLine("Enter element [{0}]: ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i <= array.Length-1; i++)
        {
            
            if (array[i+1]==array[i]+1)
            {
                sum += array[i]; 
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestIndex= i;  
                }
                else
                {
                    sum = 0;
                }
            }
        }
        Console.WriteLine(bestSum);
        
        Console.WriteLine("Maximal increasing sequence is:");
        
    }
}
