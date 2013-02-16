using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SumPolinomials
{
    static void Sum(int[] arr1, int[] arr2)
    {
        int len = Math.Max(arr1.Length, arr2.Length);
        int[] sum = new int[len];
        for (int i = 0; i < len; i++)
        {
            sum[i] = arr1[i] + arr2[i];
        }
        PrintArray(sum);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.Write(arr[i]);
            }
            else
            {
                Console.Write(arr[i] + "x^" + i + " + ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        /*Write a method that adds two polynomials. */

        Console.Write("Enter power of the first polinom: ");
        int firstPower = int.Parse(Console.ReadLine()) + 1;
        Console.Write("Enter power of the second polinom: ");
        int secondPower = int.Parse(Console.ReadLine()) + 1;
        int biggerPower = Math.Max(firstPower, secondPower);
        int[] first = new int[biggerPower];
        int[] second = new int[biggerPower];
        Console.WriteLine("Enter {0} coefficients for the first polinomial starting with the free term: ", firstPower);
        for (int i = 0; i < firstPower; i++)
        {
            first[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter {0} coefficients for the second polinomial starting with the free term: ", secondPower);
        for (int i = 0; i < secondPower; i++)
        {
            second[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum of the two polinomials is: ");
        Sum(first, second);
    }
}

