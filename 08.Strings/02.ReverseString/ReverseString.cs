using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            /*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" -> "elpmas".*/

            string str = "sample";
            Console.Write("The reversed string is: ");
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            Console.WriteLine(ch);
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.WriteLine();
        }
    }
}
