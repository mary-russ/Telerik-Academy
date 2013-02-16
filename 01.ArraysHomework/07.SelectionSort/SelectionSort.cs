using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SelectionSort
{
    static void mySwap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
    static void Main()
    {
        /*Sorting an array means to arrange its elements in increasing order. 
            Write a program to sort an array. Use the "selection sort" algorithm:
            Find the smallest element, move it at the first position, 
            find the smallest from the rest, move it at the second position, etc.*/

        int[] array = new int[] { 5, 2, 7, 10, 1, -3, 6, 3, -12, 15 };
        int helper;
        for (int i = 0; i < array.Length - 1; i++)
        {
            helper = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[helper])
                {
                    helper = j;
                }
            }
            if (helper != i)
            {
                mySwap<int>(ref array[i], ref array[helper]);
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

