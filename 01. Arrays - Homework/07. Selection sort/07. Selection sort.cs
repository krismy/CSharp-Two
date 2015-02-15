using System;
/*•	Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
        •	Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
        smallest from the rest, move it at the second position, etc.*/
class SelectionSort
{
    static void Main()
    { 
        Console.Write("Enter possitine n for number of array elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayInteger = new int[n];
        double[] arrayDouble = new double[n];
              
        Console.Write("Enter array type 1 - integer, 2 - double: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                for (int i = 0; i < arrayInteger.Length; i++)
                {
                    Console.Write("Enter element [{0}]: ", i);
                    arrayInteger[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arrayInteger[i] > arrayInteger[j])
                        {
                            int temp = arrayInteger[i];
                            arrayInteger[i] = arrayInteger[j];
                            arrayInteger[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arrayInteger[i] + " ");
                }
                break;

            case 2:
                for (int i = 0; i < arrayDouble.Length; i++)
                {
                    Console.Write("Enter element [{0}]: ", i);
                    arrayDouble[i] = double.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (arrayDouble[i] > arrayDouble[j])
                        {
                            double temp = arrayDouble[i];
                            arrayDouble[i] = arrayDouble[j];
                            arrayDouble[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(arrayDouble[i] + " ");
                }
                break;

            default:
                Console.WriteLine("Wrong entry!");
                break;
        }

    }
}
