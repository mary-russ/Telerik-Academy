using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class BinaryToDecimal
{
    static void Main()
    {
        /*Write a program to convert binary numbers to their decimal representation.*/

        List<byte> bin = new List<byte>() { 1,0,0,1,0,0,1,0,0,1,0,0};
        bin.Reverse();
        int number = 0;
        for (int i = 0; i < bin.Count; i++)
        {
            number += bin[i] * (int)Math.Pow(2, i);
        }
        Console.WriteLine("The number in decimal system is: {0}", number);
    }
}

