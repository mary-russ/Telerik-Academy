using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MostFreqNumber
{
    static void Main()
    {
        /*Write a program that finds the most frequent number in an array. Example:
	       {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} => 4 (5 times)*/

        int[] array = new int[] { 2, 7, 7, 2, 1, 7, 1 };
        int counter = 0, temp = 0, bestCounter = 0, number = 0;
        for (int i = 0; i < array.Length; i++)
        {
            temp = array[i];
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] == temp)
                {
                    counter++;
                    temp = array[j];
                }
            }
            if (counter > bestCounter)
            {
                bestCounter = counter;
                number = temp;
            }
            counter = 0;
        }
        Console.WriteLine("{0} ({1} times) ", number, bestCounter);
    }
}

