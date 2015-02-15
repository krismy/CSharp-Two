using System;

class CompareArrays
{
    static void Main()
    {
        //•	Write a program that reads two integer arrays from the console and compares them element by element.

        Console.Write("Enter arrays lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[lenght];
        int[] arrayTwo = new int[lenght];

        Console.WriteLine("Enter first array values:");
        for (int i = 0; i <= lenght - 1; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
            //arrayTwo[i]=int.Parse(Console.ReadLine());

        }
        Console.WriteLine("Enter second array values:");
        for (int i = 0; i <= lenght - 1; i++)
        {
            //arrayOne[i] = int.Parse(Console.ReadLine());
            arrayTwo[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Result:");
        for (int j = 0; j <= lenght - 1; j++)
        {
            if (arrayOne[j] > arrayTwo[j])
            {
                Console.WriteLine(arrayOne[j] + ">" + arrayTwo[j]);
            }
            else if (arrayOne[j] < arrayTwo[j])
            {
                Console.WriteLine(arrayOne[j] + "<" + arrayTwo[j]);
            }
            else
            {
                Console.WriteLine(arrayOne[j] + "=" + arrayTwo[j]);
            }
        }
    }
}

