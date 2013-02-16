using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DecimalToBinary
{
    static void Main()
    {
        /*Write a program to convert decimal numbers to their binary representation.*/

        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The decimal number {0} is: ", number);
        List<int> bin = new List<int>();
        for (int i = 0; i < 32; i++)
        {
            bin.Add(number % 2);
            number /= 2;
        }
        bin.Reverse();
        Console.WriteLine();
        
        for (int i = 0; i < bin.Count; i++)
        {
            Console.Write(bin[i]);
        }
        Console.WriteLine(" in binary system.");
        Console.WriteLine();
    }
}

