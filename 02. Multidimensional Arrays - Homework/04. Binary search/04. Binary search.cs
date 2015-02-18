using System;
/*•	Write a program, that reads from the console an array of N integers and an integer K, 
        * sorts the array and using the method Array.BinSearch() finds the largest number in the 
        * array which is ≤ K.*/

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter N for number of integer elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("[{0}]: ",i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("\nEnter integer K: ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        int search = Array.BinarySearch(array, k);

        if (search>0)
        {
            Console.WriteLine("The number nearest to K is K={0}", array[search]);
        }
        else if (search == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            search = ~search;
            Console.WriteLine("The number nearest to K is {0}", array[search-1]);
        }

    }
}

