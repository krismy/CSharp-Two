using System;
//•	Write a program that finds the maximal sequence of equal elements in an array.
class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter number for array lenght: ");
        int count = int.Parse(Console.ReadLine());
        int[] array = new int[count];
        //int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int sequence = 1;
        int sequenceMax = 0;
        int bestStart = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter Array element [{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(array[i]);
        }

        for (int j = 0; j < array.Length-1; j++)
        {

            if (array[j] == array[j + 1])
            {               
                               
                if (sequence > sequenceMax)
                {
                    sequenceMax = sequence;
                    bestStart = j-sequenceMax;
                    ++sequence;
                }
                else
                {
                    sequence = 1;
                }
                
            }
        }
        //Console.WriteLine(bestStart);
        //for (int index = bestEnd; index <= bestEnd - sequenceMax - 1; index--)
        if (sequence - bestStart >= 1)
        {

            Console.WriteLine("The elements with maximal sequence are:");
            for (int i = bestStart; i <= bestStart+sequence-1; i++)
            {
                if (i < sequence)
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
        //Console.WriteLine(sequenceMax);
    }
    
}
