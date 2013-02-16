using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MaxSumSub
{
    static void Main()
    {
        /*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
         Find in the array those K elements that have maximal sum.*/

        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        //int[] array = new int[] { 1, 5, 7, 3, 2, -1, -5, -12, 9, 4 };
        //int k = 5;
        int[] maxArray = new int[k];
        int counter = k;
        while (counter > 0)
        {
            int buffer = Int32.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > buffer)
                {
                    buffer = array[i];
                    maxIndex = i;
                }
            }
            maxArray[counter - 1] = array[maxIndex];
            array[maxIndex] = Int32.MinValue;
            counter--;
        }
        Console.Write("The maximal sum of {0} elements form elements:  ", k);
        for (int i = 0; i < k; i++)
        {
            Console.Write(maxArray[i] + " ");
        }
        Console.WriteLine();
    }
}

