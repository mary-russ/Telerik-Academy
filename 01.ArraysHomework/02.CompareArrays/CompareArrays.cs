using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CompareArrays
{
    static void Main()
    {
        /*Write a program that reads two arrays from the console and compares them element by element.*/

        Console.Write("Enter first array's length: "); //reading 1 array from the console
        int n1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[n1];
        Console.WriteLine("Enter first array's elements: ");
        for (int i = 0; i < n1; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter second array's length: "); //reading 2 array from the console
        int n2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[n2];
        Console.WriteLine("Enter second array's elements: ");
        for (int i = 0; i < n2; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }
        if (array1.Length == array2.Length)
        {
            for (int i = 0; i < n1; i++)
            {
                if (array1[i] == array2[i])
                {
                    continue; 
                }               
            }
            Console.WriteLine("The arrays are equal");
        }
        else
        {
            Console.WriteLine("The arrays are not equal");
        }

    }
}

