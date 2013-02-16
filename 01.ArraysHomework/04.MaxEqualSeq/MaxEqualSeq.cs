using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxEqualSeq
{
    static void Main()
    {
        /*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} => {2, 2, 2}.*/

        int[] array = new int[] { 4, 1, 1, 1, 7, 7, 3, 3, 3 };//=>1,1,1 - the first sequence
        int start = 0;
        int len = 1;
        int bestStart = 0, bestLen = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
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
        for (int i = 0; i < bestLen; i++)
        {
            Console.Write(array[bestStart] + " ");
        }
        Console.WriteLine();
    }
}

