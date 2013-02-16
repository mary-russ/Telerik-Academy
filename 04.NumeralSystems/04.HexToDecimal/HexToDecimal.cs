using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class HexToDecimal
{
    static void Main()
    {
        /*Write a program to convert hexadecimal numbers to their decimal representation.*/

        Console.Write("Enter positive number: ");
        string number = Console.ReadLine();
        number = number.ToUpper();
        int temp, dec = 0;
        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] >= '0' && number[i] <= '9')
            {
                temp = number[i] - '0';                
            }
            else
            {
                temp = number[i] - 'A' + 10;
            }
            dec += temp * (int)Math.Pow(16, number.Length - 1 - i);
        }
        Console.Write("The number 0x{0} is {1} in decimal system.", number, dec);
        Console.WriteLine();
    }
}

