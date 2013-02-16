using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinarySearch
{
    static void Main()
    {
        /*Write a program that finds the index of given element in a sorted array of integers by using
         the binary search algorithm (find it in Wikipedia).*/

        int[] array = { 2, 3, 8, 12, 25, 25, 30, 41, 47, 68, 102 };
        int target = 30;
        int minIndex = 0;
        int maxIndex = array.Length - 1;
        int midpoint;
        do
        {
            midpoint = (minIndex + maxIndex) / 2;
            if (target > array[midpoint])
            {
                minIndex = midpoint + 1;
            }
            else
            {
                maxIndex = midpoint - 1;
            }
        } while (array[midpoint] != target && minIndex <= maxIndex);
        if (array[midpoint] == target)
        {
            Console.WriteLine("Index: {0}", midpoint);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}

