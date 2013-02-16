using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Eratosthenes
{
    static List<long> primes = new List<long>();// stores prime numbers
    static bool IsPrime(long checkValue)
    {
        bool isPrime = true;
        foreach (long prime in primes)
        {
            if ((checkValue % prime) == 0 && prime <= Math.Sqrt(checkValue))
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
    static void Main(string[] args)
    {
        /*Write a program that finds all prime numbers in the range [1...10 000 000].
         Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

        DateTime start = DateTime.Now;
        int number = 1000000;
        primes.Add(2);//add manually number 2
        Console.Write(2);
        for (long checkValue = 3; checkValue <= number; checkValue += 2)                                                                                                                                            
        {
            if (IsPrime(checkValue))
            {
                primes.Add(checkValue); 
                Console.Write("\t{0}", checkValue);
            }
        }
        Console.WriteLine();
        TimeSpan timeElapsed = DateTime.Now - start;
        Console.WriteLine("time elapsed: " + timeElapsed);
    }
}

