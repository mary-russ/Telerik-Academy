using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SubsetSum
{
    static void Main()
    {
        /* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements
            * of the array that has a sum S. Example:arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 => yes (1+2+5+6) */

        int[] array = new int[] { 5, 3, 1, 4, 3, 5, 8 };
        int s = int.Parse(Console.ReadLine());
        int counter = 0, sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum = array[i];
            if (sum == s)
            {
                counter++;
            }
            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];
                if (sum == s)
                {
                    counter++;
                    sum = array[i];
                }
                else if (sum > s)
                {
                    sum -= array[j];
                }
            }
        }
        Console.WriteLine("There are {0} subsets with sum {1}.", counter, s);
    }
}

