using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FromAnyToAny
{
    static int Pow(int number, int pow)
    {
        if (pow == 0)
        { return 1; }
        else
        {
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result = result * number;
            }
            return result;
        }
    }
    static void Main()
    {
        /*Write a program to convert from any numeral system of given base s 
            to any other numeral system of base d (2 ≤ s, d ≤  16).*/

        Console.Write("Enter numeral system base S: ");
        string inputLine = Console.ReadLine();
        int numSystemS = int.Parse(inputLine);
        Console.Write("Enter the value in {0} numeral system: ", numSystemS);
        inputLine = Console.ReadLine();
        string originalInput = inputLine;
        byte[] inputValue = new byte[inputLine.Length];
        for (int i = 0, j = inputLine.Length - 1; i < inputValue.Length; i++, j--)
        {
            switch (inputLine[j])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    inputValue[i] = (byte)(inputLine[j] - '0');
                    break;
                case 'a':
                case 'A':
                    inputValue[i] = 10;
                    break;
                case 'b':
                case 'B':
                    inputValue[i] = 11;
                    break;
                case 'c':
                case 'C':
                    inputValue[i] = 12;
                    break;
                case 'd':
                case 'D':
                    inputValue[i] = 13;
                    break;
                case 'e':
                case 'E':
                    inputValue[i] = 14;
                    break;
                case 'f':
                case 'F':
                    inputValue[i] = 15;
                    break;
            }
        }
        int decimalValue = 0;
        for (int i = 0; i < inputValue.Length; i++)
        {
            int temp = Pow(numSystemS, i);
            temp = inputValue[i] * temp;
            decimalValue = decimalValue + temp;
        }
        Console.Write("Enter numeral system base D: ");
        inputLine = Console.ReadLine();
        int numSystemD = int.Parse(inputLine);
        StringBuilder result = new StringBuilder();
        while (decimalValue > 0)
        {
            int temp = decimalValue % numSystemD;
            decimalValue = decimalValue / numSystemD;
            switch (temp)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    result.Insert(0, temp);
                    break;
                case 10:
                    result.Insert(0, 'A');
                    break;
                case 11:
                    result.Insert(0, 'B');
                    break;
                case 12:
                    result.Insert(0, 'C');
                    break;
                case 13:
                    result.Insert(0, 'D');
                    break;
                case 14:
                    result.Insert(0, 'E');
                    break;
                case 15:
                    result.Insert(0, 'F');
                    break;
            }
        }
        Console.WriteLine("{0}(base {1}) = {2}(base {3})", originalInput, numSystemS, result.ToString(), numSystemD);
    }
}

