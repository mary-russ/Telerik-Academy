using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.PrintName
{
    class Program
    {
        static void PrintName(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        static void Main(string[] args)
        {
            /*Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
             Write a program to test this method.*/


            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintName(name);
        }
    }
}
