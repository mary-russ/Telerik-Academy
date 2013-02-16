using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SignedInBinary
{
    static void Main()
    {
        /*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

        Console.Write("Enter signed 16bit integer: ");
        string input = Console.ReadLine();
        short number = short.Parse(input);
        StringBuilder result = new StringBuilder();
        if (number >= 0)
        {
            int workingNum = number;
            for (int i = 0; i < 16; i++)
            {
                int temp = workingNum % 2;
                workingNum = workingNum / 2;
                result.Insert(0, temp);
            }
        }
        else
        {
            int workingNum = Math.Abs(number) - 1;
            for (int i = 0; i < 16; i++)
            {
                int temp = workingNum % 2;
                workingNum = workingNum / 2;
                if (temp == 0)
                {
                    result.Insert(0, '1');
                }
                else
                {
                    result.Insert(0, '0');
                }
            }
        }
        Console.WriteLine("Binary representation of signed integer {0} is: {1}", input, result.ToString());

    }
}

