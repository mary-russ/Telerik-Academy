using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CompareToNeighbours
{
    class CompareToNeighbours
    {
        static void Compare(int i, params int[] arr)
        {
            if (i < 0 || i >= arr.Length)
            {
                return;
            }

            if (i != arr.Length - 1)
            {
                if (arr[i] > arr[i + 1])
                {
                    Console.WriteLine("The number is greater than its right neighbour");
                }
                else
                {
                    Console.WriteLine("The number is smaller than its right neighbour");
                }
            }
            if (i != 0)
            {
                if (arr[i] > arr[i - 1])
                {
                    Console.WriteLine("The number is greater than its left neighbour");
                }
                else
                {
                    Console.WriteLine("The number is smaller than its left neighbour");
                }
            }
        }
        static void Main()
        {
            /*Write a method that checks if the element at given position in given array of integers 
             is bigger than its two neighbors (when such exist).*/

            int[] array = new int[] { 2, 4, 5, 2, 4, 7, 9, 1, 34, 67, 12, 56, 5, 8, 0, 4, 23, 78 };
            int n = 16;
            Compare(n, array);
        }
    }
}
