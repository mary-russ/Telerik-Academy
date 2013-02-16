using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ShowBinary
{
    static void Main()
    {
        /** Write a program that shows the internal binary representation of given 32-bit signed floating-point 
         number in IEEE 754 format (the C# type float).
         Example: -27.25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.*/

        float number = -27.25f;
        byte[] bytes = BitConverter.GetBytes(number);
        string bin = "";
        for (int i = bytes.Length - 1; i >= 0; i--)
        {
            bin += Convert.ToString(bytes[i], 2).PadLeft(8, '0');
        }
        Console.WriteLine("Float number {0} in binary: {1}", number, bin);
        Console.WriteLine();
        for (int i = 0; i < bin.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("sign -> {0}, exponent -> ", bin[i]);
            }
           
            if (i > 0 && i < 8)
            {
                Console.Write(bin[i]);  
            }
            if (i == 8)
            {
                Console.Write(bin[i] + ", mantissa -> ");  
            }
            if (i > 8)
            {
                Console.Write(bin[i]); 
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}

