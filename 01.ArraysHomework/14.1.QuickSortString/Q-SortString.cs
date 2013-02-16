using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._1.QuickSortString
{
    class QuickSortString
    {
        static List<string> Q_Sort(List<string> array)
        {
            if (array.Count <= 1)
            {
                return array;
            }

            string pivot = array[array.Count / 2];
            List<string> left = new List<string>();
            List<string> right = new List<string>();
            for (int i = 0; i < array.Count; i++)
            {
                if (i != (array.Count / 2))
                {
                    if (array[i].CompareTo(pivot) <= 0)
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
            List<string> sorted = new List<string>();
            sorted.AddRange(left);            
            sorted.Add(pivot);
            sorted.AddRange(right);
            return sorted;
        }

        static void PrintSorted(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /*Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).*/
            List<string> myArray = new List<string>() { "asjfdj", "dhgjr", "as", "gjh", "grt", "jy" };
            List<string> sortedArray = Q_Sort(myArray);
            PrintSorted(sortedArray);
        }
    }
}
