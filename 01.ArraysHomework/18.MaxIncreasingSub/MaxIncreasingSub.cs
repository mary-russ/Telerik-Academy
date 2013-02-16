using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxIncreasingSub
{
    static void Main()
    {
        /* Write a program that reads an array of integers and removes from it a minimal number of elements
         in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
	      {6, 1, 4, 3, 0, 3, 6, 4, 5} => {1, 3, 3, 4, 5}*/

        int[] array = new int[] { 1, 9, 2, 3, 8, 5, 6, 6, 8, 4 };//==> 1, 2, 3, 5, 6, 8

        int bestLength = 0;
        int[] bestResult = new int[array.Length];

        for (int start = 0; start < array.Length; start++)
        {
            int[] result = new int[array.Length];
            int resIndex = 1;
            int resLength = 1;
            result[0] = array[start];

            for (int i = start + 1; i < array.Length; i++)
            {
                if (array[i] > result[resIndex - 1])
                {
                    result[resIndex] = array[i];
                    resIndex++;
                    resLength++;
                }
                else if (resIndex > 1 && array[i] > result[resIndex - 2] && array[i] < result[resIndex - 1])
                {
                    result[resIndex - 1] = array[i];
                }
            }

            if (bestLength < resLength)
            {
                bestLength = resLength;
                bestResult = result;
            }
        }

        for (int j = 0; j < bestLength; j++)
        {
            Console.Write(bestResult[j] + " ");
        }
        Console.WriteLine();
    }
}

