using System;
//•	Write a program that finds the index of given element in a sorted array of 
//  integers by using the Binary searchalgorithm.

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Console.WriteLine("\nSorted array looks like this: " + string.Join(", ", array) + "\n");
        Console.Write("Enter which element index do you want to know: ");
        int element = int.Parse(Console.ReadLine());

        int max = lenght - 1;
        int min = 0;
        int mid = (lenght - 1) / 2;
        bool found = true;

        while (min <= max)
        {
            mid = (min + max - min) / 2;
            if (array[mid] < element)
            {
                min = mid + 1;
            }

            else if (array[mid] > element)
            {
                max = mid - 1;
            }

            else if (array[mid] == element)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Searched index is [{0}]", mid);
        }
        else
        {
            Console.WriteLine("No such index!");
        }
    }
}