using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LargestNumber
{
    static void Main()
    {
        /*Write a program, that reads from the console an array of N integers and an integer K, 
         sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. */

        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter n elements of the array: ");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine()); 
        }
        Array.Sort(array);
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.Write("Enter number k:");
        int k = int.Parse(Console.ReadLine());
        int target = Array.BinarySearch(array, k);
        if (target >= 0)
        {
            Console.WriteLine("The largest number <= {0} is {1}.", k, array[target]);
        }
        else
        {
            target = ~target;
            Console.WriteLine("The largest number <= {0} is {1}.", k, array[target - 1]);
        }
    }
}

