using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LongestSequence
{
    struct result
    {
        public int sequence;
        public string value;
    }

    static result checkLine(string[,] matrix, int row, int col)
    {
        result current;
        current.sequence = 1;
        current.value = matrix[row, col];
        for (int i = col + 1; i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == current.value)
            {
                current.sequence++;
            }
            else
            {
                break;
            }
        }
        return current;
    }

    static result checkColumn(string[,] matrix, int row, int col)
    {
        result current;
        current.sequence = 1;
        current.value = matrix[row, col];
        for (int i = row + 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, col] == current.value)
            {
                current.sequence++;
            }
            else
            {
                break;
            }
        }
        return current;
    }

    static result checkLeftDiagonal(string[,] matrix, int row, int col)
    {
        result current;
        current.sequence = 1;
        current.value = matrix[row, col];
        for (int i = row + 1, j = col - 1; i < matrix.GetLength(0) && j >= 0; i++, j--)
        {
            if (matrix[i, j] == current.value)
            {
                current.sequence++;
            }
            else
            {
                break;
            }
        }
        return current;
    }

    static result checkRightDiagonal(string[,] matrix, int row, int col)
    {
        result current;
        current.sequence = 1;
        current.value = matrix[row, col];
        for (int i = row + 1, j = col + 1; i < matrix.GetLength(0) && j < matrix.GetLength(1); i++, j++)
        {
            if (matrix[i, j] == current.value)
            {
                current.sequence++;
            }
            else
            {
                break;
            }
        }
        return current;
    }

    static void Main()
    {
        /*We are given a matrix of strings of size N x M. Sequences in the matrix we define
         as sets of several neighbor elements located on the same line, column or diagonal.
         Write a program that finds the longest sequence of equal strings in the matrix.*/

        string[,] matrix = {
                        { "ha", "fifi", "ho","hi"  },
                        { "fo", "ha", "hi", "xx" },
                        { "xxx", "ho", "ha", "xx" }
                        };
        int bestSequence = 0;
        string bestValue = "";
        result current;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                current = checkLine(matrix, row, col);
                if (current.sequence > bestSequence)
                {
                    bestSequence = current.sequence;
                    bestValue = current.value;
                }
                current = checkColumn(matrix, row, col);
                if (current.sequence > bestSequence)
                {
                    bestSequence = current.sequence;
                    bestValue = current.value;
                }
                current = checkLeftDiagonal(matrix, row, col);
                if (current.sequence > bestSequence)
                {
                    bestSequence = current.sequence;
                    bestValue = current.value;
                }
                current = checkRightDiagonal(matrix, row, col);
                if (current.sequence > bestSequence)
                {
                    bestSequence = current.sequence;
                    bestValue = current.value;
                }
            }
        }
        Console.WriteLine(bestValue + " -> " + bestSequence + " times.");      
    }
}

