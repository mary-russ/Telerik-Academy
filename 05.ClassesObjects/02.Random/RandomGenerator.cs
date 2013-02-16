using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.RandomNumber
{
    class RandomGenerator
    {
        static void Main(string[] args)
        {
            /*Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

            Random r_number = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(r_number.Next(100, 200) + " ");
            }
            Console.WriteLine();
        }
    }
}
