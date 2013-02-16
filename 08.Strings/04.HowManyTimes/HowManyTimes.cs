using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.HowManyTimes
{
    class HowManyTimes
    {
        static void Main(string[] args)
        {
            /*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).*/

            string str = "We are living in an yellow submarine. We don't have anything else.Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string insense = str.ToLower();
            string sub = "in";
            int index = insense.IndexOf(sub);
            int counter = 0;//вече има един индекс, но в цикъла брои с един повече и затова се сетва на 0
            while (index != -1)
            {
               index = insense.IndexOf(sub, index + 1);
               counter++;
            }

            Console.WriteLine("The result is: " + counter);
        }
    }
}
