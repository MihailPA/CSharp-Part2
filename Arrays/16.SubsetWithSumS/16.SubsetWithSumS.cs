//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;


namespace _16.SubsetWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sum that will be found S=");
            int s = int.Parse(Console.ReadLine());
          
            Console.Write("Enter the number of the element in the array N=");
            int n = int.Parse(Console.ReadLine());
           
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int counter = 0;
            string[] parseBinnary = new string[n];
            for (int i = 1; i < (int)Math.Pow(2, n); i++)
            {
                string bin = Convert.ToString(i, 2).PadLeft(n, '0');
                for (int j = 0; j < n; j++)
                {
                    parseBinnary[j] = Convert.ToString(bin[j]);
                    sum = sum + int.Parse(parseBinnary[j]) * array[j];
                }
                if (sum == s)
                {
                    counter++;
                }
                sum = 0;
            }
            if (counter > 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
