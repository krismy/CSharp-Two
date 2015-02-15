using System;
//•	Write a program that sorts an array of integers using the Quick sort algorithm.

class QuickSort
{
     static public int Partition(int [] numbers, int left, int right)

        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                {
                    left++;
                }
 
                while (numbers[right] > pivot)
                {
                    right--;
                }
                
                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }

            }

        }
        static public void QuickSort_Recursive(int [] arr, int left, int right)
        {
            // For Recusrion
            if(left < right)
            {
                int pivot = Partition(arr, left, right);

                if(pivot > 1)
                {
                    QuickSort_Recursive(arr, left, pivot - 1);
                }
 
                if(pivot + 1 < right)
                {
                    QuickSort_Recursive(arr, pivot + 1, right);
                }
            }
        }

        static void Main(string[] args)
        {

            Console.Write("Enter array lenght: ");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
           
            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter element [{0}]: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
           
            QuickSort_Recursive(array, 0, len - 1);
            Console.WriteLine("Result:");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
}

