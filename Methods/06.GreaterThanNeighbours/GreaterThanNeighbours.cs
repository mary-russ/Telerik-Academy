using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.GreaterThanNeighbours
{
    class GreaterThanNeighbours
    {
        static int IsGreater(int[] arr)
        {
            for ( int i = 1; i < arr.Length - 1; i++)
            {                          
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    //Console.WriteLine("number on position {0}: {1} is greater than its neightbours - left:{2} and right: {3}",
                    //    i, arr[i], arr[i - 1], arr[i + 1]);
                    return i;
                }
            }
            return -1;
        }
        static void Main()
        {
            /*Write a method that returns the index of the first element in array that is bigger 
             than its neighbors, or -1, if there’s no such element.*/

            int[] array = new int[] { 2, 4, 5, 2, 4, 7, 9, 1, 34, 67, 12, 56, 5, 8, 0, 4, 23, 78 };
            Console.WriteLine(IsGreater(array));
        }
    }
}
