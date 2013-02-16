using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class QuickSort
{
    static List<int> Q_Sort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int pivot = array[array.Count / 2];
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        for (int i = 0; i < array.Count; i++)
        {
            if (i != (array.Count / 2))
            {
                if (array[i] <= pivot)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }
        }
        left = Q_Sort(left);
        right = Q_Sort(right);
        List<int> sorted = new List<int>();
        sorted.AddRange(left);
        sorted.Add(pivot);
        sorted.AddRange(right);
        return sorted;
    }

    static void PrintSorted(List<int> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        /*Quick sort algorithm - integers*/

        List<int> myArray = new List<int>() { 20, 5, 36, 8, -6, 9, -13, 25, -6, 7 };
        List<int> sortedArray = Q_Sort(myArray);
        PrintSorted(sortedArray);
    }
}

