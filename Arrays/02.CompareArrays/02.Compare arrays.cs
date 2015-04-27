﻿//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;


namespace Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparing two arrays..");
            Console.Write("Enter size of the first array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter size of the second array: ");
            int m = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[m];
            bool isEqual = true;
            if (n == m)
            {
                Console.WriteLine("Enter {0} numbers for the first array: ", n);
                for (int i = 0; i < n; i++)
                {
                    Console.Write("First Array[{0}] = ", i);
                    firstArray[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter {0} numbers for the second array: ", m);
                for (int i = 0; i < m; i++)
                {
                    Console.Write("Second Array[{0}] = ", i);
                    secondArray[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isEqual = false;
                        break;
                    }
                }

            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine("Equal = {0}", isEqual);
        }
    }
}
