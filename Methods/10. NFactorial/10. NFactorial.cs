//Problem 10. N Factorial
//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

using System;
using System.Numerics;


namespace _10.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            Console.BufferHeight = Console.BufferHeight = 250;
            int[] myArray = new int[100];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }
            Multiplies(myArray);

        }
        static void Multiplies(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                BigInteger currentN = FactorialN(array[i]);
                Console.WriteLine(currentN);
            }
        }

        static BigInteger FactorialN(int n)
        {
            BigInteger factorialN = 1;
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * (i + 1);
            }
            return factorialN;
        }
    }
}
