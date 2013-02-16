using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Brackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            /*Write a program to check if in a given expression the brackets are put correctly.
                Example of correct expression: ((a+b)/5-d).
                Example of incorrect expression: )(a+b)).*/

            //string expression = "((a+b)/5-d)";
            string expression = "(a+b)/5-d)";
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                char leftBracket = '(';
                char rightBracket = ')';
                if (expression[i] == leftBracket)
                {
                    counter++;
                }
                else if (expression[i] == rightBracket)
                {
                    counter--;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("The brackets in expression are put correctly!");
            }
            else
            {
                Console.WriteLine("The brackets in expression are not put correctly!");
            }
        }
    }
}
