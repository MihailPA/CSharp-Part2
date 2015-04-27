//Problem 15. Prime numbers
//Write a program that finds all prime numbers in the range [1...10 000 000].
//Use the Sieve of Eratosthenes algorithm.

using System;

namespace _15.PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] myArr = new bool[10000000];

            for (int i = 2; i < Math.Sqrt(myArr.Length); i++)
            {
                if (myArr[i] == false)
                {
                    for (int j = i * i; j < myArr.Length; j = j + i)
                    {
                        myArr[j] = true;
                    }
                }
            }
            for (int i = 2; i < myArr.Length; i++)
            {
                if (myArr[i] == false)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
    }
}
