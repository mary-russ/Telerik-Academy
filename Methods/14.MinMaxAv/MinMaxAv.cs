using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class MinMaxAv
{
    static void MinOfSet(List<int> myList)
    {
        int min = myList.Min();
        Console.WriteLine("The minimum number in the set is: {0}", min);
    }

    static void MaxOfSet(List<int> myList)
    {
        int max = myList.Max();
        Console.WriteLine("The maximum number in the set is: {0}", max);
    }

    static void AverageOfSet(List<int> myList)
    {
        double average = myList.Average();
        Console.WriteLine("The average of the numbers in the set is: {0}", average);
    }

    static void SumOfSet(List<int> myList)
    {
        int sum = myList.Sum();
        Console.WriteLine("The sum of the numbers in the set is: {0}", sum);
    }

    static void ProductOfSet(List<int> myList)
    {
        int product = 1;
        for (int i = 0; i < myList.Count; i++)
        {
            product *= myList[i];
        }
        Console.WriteLine("The product of the numbers in the set is: {0}", product);
    }

    static void Main(string[] args)
    {
        /*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
         Use variable number of arguments.*/
        Console.Write("Enter number of arguments: ");
        int number = int.Parse(Console.ReadLine());
        List<int> set = new List<int>();
        Console.WriteLine("Enter {0} arguments: ", number);
        for (int i = 0; i < number; i++)
        {
            set.Add(int.Parse(Console.ReadLine()));
        }
        MinOfSet(set);
        MaxOfSet(set);
        AverageOfSet(set);
        SumOfSet(set);
        ProductOfSet(set);

    }
}

