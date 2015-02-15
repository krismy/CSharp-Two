using System;
/*
    Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
    Print the obtained array on the console.
*/

class AllocateArray
{
    static void Main()
    {
        int count = 20;
        int[] array = new int[count];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }
    }
}
