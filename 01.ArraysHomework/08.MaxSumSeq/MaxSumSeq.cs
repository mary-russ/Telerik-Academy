using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxSumSeq
{
    static void Main(string[] args)
    {
        /*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/

        int[] array = new int[] { -20, 3, 6, -1, 2, -15, 6, 4, 8, -8 };
        int sum = 0, maxSum = 0, len = 1, bestLen = 1, endIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = array[i];
            len = 1;
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];
                len++;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestLen = len;
                    endIndex = j;
                }
            }
        }
        Console.WriteLine(maxSum);
        for (int i = endIndex - bestLen + 1; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}

