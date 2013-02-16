using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinaryToHex
{
    static void Main()
    {
        /*Write a program to convert binary numbers to hexadecimal numbers (directly).*/

        //string binNumber = "1111001101101";
        Console.Write("Enter a binary number: ");
        string binNumber = Console.ReadLine();
        int rem = binNumber.Length % 4;
        if (rem != 0)
        {
            binNumber = new string('0', 4 - rem) + binNumber;//puts leading zeroes
        }
        List<string> result = new List<string>();
        for (int i = 0; i <= binNumber.Length - 4; i+= 4)
        {         
            string sub = binNumber.Substring(i, 4);
            result.Add(sub);           
        }
        Console.Write("The binary number {0} is: ", binNumber);
        for (int i = 0; i < result.Count ; i++)
        {
            switch (result[i])
            {
                case "0000": Console.Write("0"); break;
                case "0001": Console.Write("1"); break;
                case "0010": Console.Write("2"); break;
                case "0011": Console.Write("3"); break;
                case "0100": Console.Write("4"); break;
                case "0101": Console.Write("5"); break;
                case "0110": Console.Write("6"); break;
                case "0111": Console.Write("7"); break;
                case "1000": Console.Write("8"); break;
                case "1001": Console.Write("9"); break;
                case "1010": Console.Write("A"); break;
                case "1011": Console.Write("B"); break;
                case "1100": Console.Write("C"); break;
                case "1101": Console.Write("D"); break;
                case "1110": Console.Write("E"); break;
                case "1111": Console.Write("F"); break;
                default: Console.WriteLine("You didn't enter binary number."); break;
            }
        }
        Console.Write(" in hexadecimal system.");
        Console.WriteLine();
    }
}

