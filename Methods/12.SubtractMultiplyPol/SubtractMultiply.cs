using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubtractMultiply
{
    static void SubtractPol(int[] arr1, int[] arr2)
    {
        int len = Math.Max(arr1.Length, arr2.Length);
        int[] sub = new int[len];
        for (int i = 0; i < len; i++)
        {
            sub[i] = arr1[i] - arr2[i];
        }
        PrintArray(sub);
    }

    static void MultiplyPol(int[] arr1, int[] arr2)
    {
        int len = ((arr1.Length - 1) + (arr2.Length - 1) + 1);
        int[] product = new int[len];
        for (int i = arr1.Length - 1; i >= 0; i--)
        {
            for (int j = arr2.Length - 1; j >= 0; j--)
            {
                int temp = arr1[i] * arr2[j];
                product[i + j] = product[i + j] + temp;
            }
        }
        PrintArray(product);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (i == 0 && arr[i] != 0)
            {
                Console.Write(" + " + arr[i]);
            }
            else if(arr[i] > 0 && i != arr.Length-1)
            {
                Console.Write( " + " + arr[i] + "x^" + i);
            }
            else if (i == arr.Length -1)
            {
                 Console.Write(arr[i] + "x^" + i);
            }
            else if (arr[i] < 0)
            {
               Console.Write( " " + arr[i] + "x^" + i); 
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        /*Subtraction and multiplication of polynomials.*/

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
        Console.WriteLine("The difference between two polinomials is: ");
        SubtractPol(first, second);
        Console.WriteLine("The product of the two polinomials is: ");
        MultiplyPol(first, second);

    }
}

