using System;
//•	Write a program that finds all prime numbers in the range [1...10 000 000]. 
//  Use the Sieve of Eratosthenesalgorithm.

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter number in range [1...10 000 000]: ");
        int enterd = int.Parse(Console.ReadLine());
        bool[] array = new bool[enterd];
        for (int i = 0; i < enterd; i++)
        {
            array[i] = true;
        }
        for (int i = 2; i <= Math.Sqrt(enterd); i++)
        {
            if (array[i] == true)
            {
                int multily = 1;
                for (int j = i * i; j < enterd; j = multily * i)
                {
                    array[j] = false;
                    multily++;
                }
            }
        }
        Console.WriteLine("The prime numbers are:");
        for (int i = 2; i < enterd; i++)
        {
            if (array[i] == true)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}

