using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Factorial
{
     static byte[] Fact(byte n)
        {
            if (n < 2)
                return new byte[] { 1 };
            byte[] result = { 1 };
            byte[] num = { 2 };
            for (int i = 1; i < n; i++)
            {
                result = Multiply(result, num);
                num = Add(num, 1);
            }
            return result;
        }
 
        static byte[] Multiply(byte[] a, byte[] b)
        {
            List<byte> result = new List<byte>();
 
            byte add = 0;
            for (int i = 0; i < a.Length + b.Length - 1; i++)
            {
                result.Add(add);
                for (int j = 0; j < b.Length; j++)
                {
                    if (i - j >= 0 && i - j < a.Length)
                    {
                        result[i] += (byte)(a[i - j] * b[j]);
                    }
                }
 
                if (result[i] > 9)
                {
                    add = (byte)(result[i] / 10);
                    result[i] %= 10;
                }
                else
                {
                    add = 0;
                }
            }
 
            if (add > 0)
            {
                result.Add(add);
            }
 
            return result.ToArray();
        }
 
        static byte[] Add(byte[] a, byte n)
        {
            a[0] += n;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > 9)
                {
                    a[i + 1] += (byte)(a[i] / 10);
                    a[i] %= 10;
                }
                else
                {
                    break;
                }
            }
            if (a[a.Length - 1] > 9)
            {
                byte[] result = new byte[a.Length + 1];
                Array.Copy(a, 0, result, 0, a.Length);
                int ind = result.Length - 1;
                result[ind] = (byte)(result[ind - 1] / 10);
                result[ind - 1] %= 10;
                return result;
            }
            else
            {
                return a;
            }
        }
 
        static void PrintArr(byte[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

    static void Main()
    {
        /*Write a program to calculate n! for each n in the range [1..100]. 
         Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.*/

        Console.Write("n = ");
        string input = Console.ReadLine();
        byte n = byte.Parse(input);
        Console.Write("{0}! = ", n);
        PrintArr(Fact(n));

    }
}

