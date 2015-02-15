using System;
//•	Write a program that finds in given array of integers a sequence of given sum S (if present).

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        Console.Write("Enter wanted sum S: ");
        double s = double.Parse(Console.ReadLine());
        double[] array = new double[lenght];
        //double bestSum = double.MinValue;
        int bestStartIndex = 0;
        int endIndex = 0;
        double sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            array[i] = double.Parse(Console.ReadLine());
        }

        for (int j = 0; j < array.Length; j++)
        {
            sum = array[j];
            for (int i = j+1; i < array.Length; i++)
            {
                sum += array[i];
                if (sum == s)
                {
                    bestStartIndex = j;
                    endIndex = i;
                }
                else if (sum < s)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
           
        }
        if (endIndex-bestStartIndex > 1)
        {

            Console.WriteLine("The elements with sum {0}:", s);
            for (int i = bestStartIndex; i <= endIndex; i++)
            {
                if (i < endIndex)
                {
                    Console.Write(array[i] + ", ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("No such sequence!");
        }

    }
}

