using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.HowManyTimes
{
    class HowManyTimes
    {
        static int HowMany(int num, params int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {                               
                if (num == arr[i])
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            /*Write a method that counts how many times given number appears in given array. 
             Write a test program to check if the method is working correctly.*/

            int[] array = new int[] { 2, 5, 6, 2, 3, 4, 5, 7, 8, 4, 5, 6, 3, 2, 8, 7, 9, 2, 4, 5, 6, 7, 8, 9 };
            int n = 7;
            Console.WriteLine(HowMany(n, array));
        }
    }
}
