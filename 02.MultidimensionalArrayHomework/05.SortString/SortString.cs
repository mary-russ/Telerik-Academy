using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SortString
{
    static void Main()
    {
        /*You are given an array of strings. Write a method that sorts the array by 
         the length of its elements (the number of characters composing them).*/

        string[] array = new string[] { "absde", "dkflety", "shj", "aa", "wertyuui", "dfgth", "asf", "z", "a", "s" };
        Console.WriteLine("Unsorted: {0}", String.Join(", ", array));
        var result = array.OrderBy(a => a.Length);//sort only by length
        Console.WriteLine("Sorted: {0} ", String.Join(", ", result));

    }
}

