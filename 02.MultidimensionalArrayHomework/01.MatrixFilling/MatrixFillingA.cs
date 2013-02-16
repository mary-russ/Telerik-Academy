using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MatrixFillingA
{
    static void Main()
    {
        /*Write a program that fills and prints a matrix of size (n, n) - A*/

        Console.Write("Enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n*n; j += n)
            {
                Console.Write("{0,-4}", j);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

