using System;
/*•	Write a program that reads two integer numbers N and K and an array of N elements from the console.
          •	Find in the array those K elements that have maximal sum.*/

class MaximalKSum
{
    //static void EnterArray()
    //{
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        Console.WriteLine("Enter element [{0}]: ", i);
    //        array[i] = int.Parse(Console.ReadLine());
    //    }
    //}
    static void Main()
    {
        Console.Write("Enter possitive number N for array elements: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter possitive number K (K<=N) for maximum numbers of the array: ");
        int k = int.Parse(Console.ReadLine());
        int[] arrayInteger = new int[n];
        double[] arrayDouble = new double[n];
       
        while (k>n)
        {
            Console.WriteLine("K must be smaller than N!");
            Console.Write("Enter possitine number N for array elements: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter possitive number K for maximum numbers of the array: ");
            k = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter array type 1 - integer, 2 - double: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
	    {
            case 1:
                for (int i = 0; i < arrayInteger.Length; i++)
                    {
                        Console.Write("Enter element [{0}]: ", i);
                        arrayInteger[i] = int.Parse(Console.ReadLine());
                    }
                Array.Sort<int>(arrayInteger);
                    for (int i = n-k; i < n; i++)
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
                 Array.Sort<double>(arrayDouble);
                    for (int i = n-k; i < n; i++)
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

