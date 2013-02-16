using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.GetMax
{
class GetMax
{
    static int GetMaxInt(int x, int y)
    {
        int max = x;
        if (y > x)
        {
            max = y; 
        }
        return max;
    }
    static void Main()
    {
        /*Write a method GetMax() with two parameters that returns the bigger of two integers.
            Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/


        Console.Write("Enter number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        int n3 = int.Parse(Console.ReadLine());
        int maxFrom3 = GetMaxInt(GetMaxInt(n1, n2), n3);
        Console.WriteLine("The maximal number from your input is: {0}", maxFrom3);
    }
}
}
