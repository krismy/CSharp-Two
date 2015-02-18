using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//•	You are given an array of strings. Write a method that sorts the array by the length of its 
 //  elements (the number of characters composing them).

 class SortByStringLength
    {
        static void Main()
        {
            Console.Write("Enter number of array elements: ");
            int len = int.Parse(Console.ReadLine());
            string[] array = new string[len];
            Console.WriteLine("Enter string elements:");

            for (int i = 0; i < len; i++)
			{
			   Console.Write("[{0}]: ",i);
               array[i]=Console.ReadLine();
			}
          
            Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

            string text = string.Join(",", array);

            Console.WriteLine(text);
        }
    }