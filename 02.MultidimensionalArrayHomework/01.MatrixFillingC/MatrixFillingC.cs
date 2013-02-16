using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MatrixFillingC
{
    static void Main()
    {
        /*Write a program that fills and prints a matrix of size (n, n) - C */

        Console.Write("Enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 1;
        matrix[n - 1, 0] = counter;
        matrix[0, n - 1] = n * n;
        counter++;
        for (int index = n - 2; index >= 0; index--)
        {
            for (int row = 0; row <= n - 1; row++)
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    if (row == col)
                    {
                        if (row - index < 0)
                        {
                            continue;
                        }
                        else
                        {
                            matrix[col, row - index] = counter;
                            counter++;
                        }
                    }
                }
            }
        }
        counter = (n * n) - 1;
        for (int index = n - 2; index > 0; index--)
        {
            for (int col = n - 1; col > 0; col--)
            {
                for (int row = 0; row <= n - 1; row++)
                {
                    if (row == col)
                    {
                        if (col - index < 0)
                        {
                            continue;
                        }
                        else
                        {
                            matrix[col - index, row] = counter;
                            counter--;
                        }
                    }
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3} ", matrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}

