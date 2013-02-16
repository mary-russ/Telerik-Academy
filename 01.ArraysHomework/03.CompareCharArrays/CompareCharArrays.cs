using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CompareCharArrays
{
    static void Main()
    {
        /*Write a program that compares two char arrays lexicographically (letter by letter).*/

        Console.Write("enter first array's length: "); //reading 1 array from the console
        int n1 = int.Parse(Console.ReadLine());
        char[] array1 = new char[n1];
        for (int i = 0; i < n1; i++)
        {
            array1[i] = char.Parse(Console.ReadLine());
        }
        Console.Write("enter second array's length: "); //reading 2 array from the console
        int n2 = int.Parse(Console.ReadLine());
        char[] array2 = new char[n2];

        for (int i = 0; i < n2; i++)
        {
            array2[i] = char.Parse(Console.ReadLine());
        }
        bool equal = false;
        for (int i = 0; i < Math.Min(n1, n2); i++)
        {
            if ((int)array1[i] < (int)array2[i])
            {
                Console.WriteLine("first array is before second");
                break;
            }
            else if ((int)array1[i] > (int)array2[i])
            {
                Console.WriteLine("second array is before first");
                break;
            }
            else if ((int)array1[i] == (int)array2[i])
            {
                equal = true;
            }
            
            else if(equal)
            {
                Console.WriteLine("the arrays are equal");             
            }
         }       
    }
}

