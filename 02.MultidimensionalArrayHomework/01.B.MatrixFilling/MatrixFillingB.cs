using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MatrixFillingB
{
    static void Main()
    {
        /*Write a program that fills and prints a matrix of size (n, n) - B*/

        Console.Write("Enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int x = 0;//rows
        int y = 0;//columns
        int direction = 1; //0-right, then up; 1-down; 2-right, then down; 3-up

        for (int i = 1; i <= n * n; i++)
        {
            matrix[y, x] = i;

            switch (direction)
            {
                case 0:               
                    y--;
                    direction = 3;
                    break;

                case 1:
                    y++;
                    if (y >= n)
                    {
                        y--;
                        x++;
                        direction = 0;
                    }
                    break;

                case 2:
                    y++;     
                    direction = 1;
                    break;

                case 3:
                    y--;
                    if (y < 0)
                    {
                        y++;
                        x++;
                        direction = 2;
                    }
                    break;
            }
        }

        // print result
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3} ", matrix[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine(); 
    }
}

