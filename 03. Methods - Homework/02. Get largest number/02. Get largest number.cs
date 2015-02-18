using System;

class GetLargestNumber
{
    static void Main()
    {
        /*•	Write a method GetMax() with two parameters that returns the larger of two integers.
          •	Write a program that reads 3 integers from the console and prints the largest of 
         * them using the method GetMax(). */
        Console.Write("Enter first integer: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int j = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("The largest of them is: ");
        GetMaxInteger(i,j,k);
    }

    private static void GetMaxInteger(int i, int j,int k)
    {
        if (i>=j&&i>=k)
	    {
		    Console.WriteLine(i);
	    }
        else if (j>=k&&j>=i)
        {
            Console.WriteLine(j);
        }
        else
        {
            Console.WriteLine(k);
        }
        
    }
}

