using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ChooseVariant
{
    static void ReverseNumber(int num)
    {
        string str = num.ToString();
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }

    static float GetAverage(int[] arr)
    {
        int sum = 0;
        float average;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        average = (float)sum / arr.Length;
        return average;
    }
    static float SolveEquation(float a, float b)
    {
        return -a / b;
    }

    static void Main(string[] args)
    {
        Console.Write("Choose \"1\" for reversing number, \"2\" for calculating average, or \"3\" for linear equation: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter nubmer to be reversed: ");
                int n = int.Parse(Console.ReadLine());
                ReverseNumber(n);
                Console.WriteLine();                    
                break;
            case 2:
                Console.Write("Enter number of members of sequence: ");
                int m = int.Parse(Console.ReadLine());
                int[] array = new int[m];
                for (int i = 0; i < m; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());  
                }
                Console.WriteLine("The average is: {0}", GetAverage(array));
                break;
            case 3:
                Console.Write("Enter coefficient a != 0: ");
                float a = float.Parse(Console.ReadLine()); 
                Console.Write("Enter coefficient b: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("The solution is: {0}",SolveEquation(a, b));
                break;
            default: Console.WriteLine("You didn't enter 1, 2 or 3");
                break;
        }           
    }
}

