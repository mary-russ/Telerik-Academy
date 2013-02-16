using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MultipliedBy5
{
    static void Main()
    {
        /*Write a program that allocates array of 20 integers and initializes each element by its index
            multiplied by 5. Print the obtained array on the console.*/

        int[] array = new int[20];
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
            Console.WriteLine("The {0} element of the array is {1}", i, array[i]);
        }
    }
}

