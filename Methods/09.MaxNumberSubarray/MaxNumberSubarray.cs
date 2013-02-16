using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxNumberSubarray
{
    static int MaxNumber(int start, int end, int[] arr)
    {
        for (int i = start; i <= end; i++)
        {
            for (int j = i + 1; j <= end; j++)
            {
                if (arr[i] > arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        return end;
    }

    static int[] SortAscending(int[] arr)
    {
        int len = arr.Length;
        int[] sorted = new int[len];
        for (int i = 0; i < len; i++)
        {
            int tempIndex = MaxNumber(0, len - 1, arr);
            sorted[len - i - 1] = arr[tempIndex];
            arr[tempIndex] = int.MinValue;
        }
        return sorted;
    }  

    static void PrintAscending(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " "); 
        }
    }
    static void PrintDescending(int[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
    static void Main()
    {
        /*Write a method that return the maximal element in a portion of array of integers starting at given index.
         Using it write another method that sorts an array in ascending / descending order.*/

        int[] array = new int[] { 2, 6, 1, 4, 123, 3, 34, 199, 68, 124, 36, 999, 24 };
        Console.WriteLine("The initial array: ");
        PrintAscending(array);
        Console.WriteLine();
        int startInterval = 3, endInterval = 10;
        Console.Write("The maximal element in a subarray with starting index {0} and ending index {1} is: ", startInterval, endInterval);
        Console.WriteLine(array[MaxNumber(startInterval, endInterval, array)]);
        Console.WriteLine();
        int[] sortedArray = SortAscending(array);
        Console.WriteLine("The array sorted in ascending order: ");
        PrintAscending(sortedArray);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The array sorted in descending order: ");
        PrintDescending(sortedArray);
        Console.WriteLine();
        Console.WriteLine();
    }
}

