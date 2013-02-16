using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SeqSum
{
    static void Main()
    {
        /*Write a program that finds in given array of integers a sequence of given sum S (if present).
         Example: {4, 3, 1, 4, 2, 5, 8}, S=11 => {4, 2, 5} */

        int[] array = new int[] { 2, 3, 4, 4, 2, 5, 8 };
        int s = 11;
        int sum = 0;
        int currentSum = 0, startIndex = 0, endIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == s)
                {
                    sum = currentSum;
                    endIndex = j;
                    startIndex = i;
                    break;
                }
                else if (currentSum > s)
                {
                    break;
                }
            }
        }
        Console.WriteLine(sum);
        for (int k = startIndex; k <= endIndex; k++)
        {
            Console.Write(array[k] + " ");
        }
    }
}

