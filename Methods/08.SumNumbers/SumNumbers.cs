using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SumNumbers
{
    static void SumNum(int[] num1, int[] num2)
    {
        int maxLen = Math.Max(num1.Length, num2.Length) + 1;
        int minLen = Math.Min(num1.Length, num2.Length);
        int[] result = new int[maxLen];
        int sum = 0;
        for (int i = 0; i < minLen; i++)
        {
            sum += num1[i] + num2[i];
            if (sum > 9)
            {
                result[i] = sum - 10;
                sum = 1;
            }
            else
            {
                result[i] = sum;
                sum = 0;
            }              
        }
        if (num1.Length == maxLen)
        {
            for (int i = num2.Length; i < maxLen; i++)
            {
                sum += num1[i];
                result[i] = sum;
                sum = 0;
            }
        }
        else if(num2.Length == maxLen)
        {
            for (int i = num1.Length; i < maxLen; i++)
            {
                sum += num2[i];
                result[i] = sum;
                sum = 0;
            }
        }
        result[maxLen - 1] = sum;
        PrintResult(result);
    }
    static void PrintResult(int[] res)
    {
        for (int i = res.Length - 1; i >= 0; i--)
        {
            Console.Write(res[i]);
        }
    }

    static void Main()
    {
        /*Write a method that adds two positive integer numbers represented as arrays of digits 
            (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
            Each of the numbers that will be added could have up to 10 000 digits. */

        SumNum(new int[] { 2, 6, 3}, new int[] { 7, 3, 9});//the numbers are 362 and 937, represented reversed as required
        Console.WriteLine();
    }
}

