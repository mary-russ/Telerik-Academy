using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class DecimalToHex
{
    static void Main()
    {
        /*Write a program to convert decimal numbers to their hexadecimal representation. */

        Console.Write("Enter a decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Decimal number {0} is: 0x", number);
        List<int> bin = new List<int>();
        while(number > 0)
           {
               int remainder = number % 16;        
               bin.Add(remainder);                   
               number /= 16;
            }
        bin.Reverse();
        for (int i = 0; i < bin.Count; i++)
        {
        if (bin[i] > 9)
        {
            switch (bin[i])
            {
                case 10: Console.Write('A'); break;
                case 11: Console.Write('B'); break;
                case 12: Console.Write('C'); break;
                case 13: Console.Write('D'); break;
                case 14: Console.Write('E'); break;
                case 15: Console.Write('F'); break;
            }
        }
        else
        {
            Console.Write(bin[i]);
        }
    }
    Console.WriteLine(" in hexidecimal system.");
    Console.WriteLine();
}
}

