using System;
//•	Write a program that finds the most frequent number in an array.

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array lenght: ");
        int lenght = int.Parse(Console.ReadLine());
        double[] array = new double[lenght];
        int counter = 1;
        double mostFrequent = 0;
        int counterMax = 1;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter element [{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < lenght; i++)
        {
            counter = 1;
            for (int j = i+1; j < lenght; j++)
            {
                
                if (array[i]==array[j])
                {
                    ++counter; 
                }
                if (counter>counterMax)
                {
                    counterMax = counter;
                    mostFrequent = array[i];
                }
            }
        }
        Console.WriteLine("Most frequent number is {0}({1} times)",mostFrequent,counterMax);
    }
}