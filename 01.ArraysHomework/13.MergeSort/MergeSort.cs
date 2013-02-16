using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class MergeSort
    {
        static void Sort(int[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Sort(data, left, middle);
                Sort(data, middle + 1, right);
                Merge(data, left, middle, middle + 1, right);
            }
        }
        static void Merge(int[] data, int left, int middle, int middle1, int right)
        {
            int oldPosition = left;
            int size = right - left + 1;
            int[] temp = new int[size];
            int i = 0;

            while (left <= middle && middle1 <= right)
            {
                if (data[left] <= data[middle1])
                    temp[i++] = data[left++];
                else
                    temp[i++] = data[middle1++];
            }
            if (left > middle)
                for (int j = middle1; j <= right; j++)
                    temp[i++] = data[middle1++];
            else
                for (int j = left; j <= middle; j++)
                    temp[i++] = data[left++];
            Array.Copy(temp, 0, data, oldPosition, size);
        }

        static void Main()
        {
            /*Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).*/

            int[] data = new int[] { 2, -33, 1, -6, 23, 98, 4, 6, 14, 3, 45 };

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();

            Sort(data, 0, data.Length - 1);

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine();
        }
    }

