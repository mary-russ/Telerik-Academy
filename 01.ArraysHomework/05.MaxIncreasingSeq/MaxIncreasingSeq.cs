using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxIncreasingSeq
{
    static void Main()
    {
        /*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4} => {2, 3, 4}.*/

        int[] array = new int[] { 2, 3, 1, 1, 2, 3, 4, 5, 3 };
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                start = i;
                len++;
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            else
            {
                len = 1;
            }
        }

        for (int j = bestStart - bestLen + 1; j <= bestStart; j++)
        {
            Console.Write(array[j] + " ");
        }
        Console.WriteLine();

    }
}

