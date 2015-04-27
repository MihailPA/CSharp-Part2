//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).


using System;


namespace _10.FindSumInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sum S=");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
       
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Element[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = 0;
            int startIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                startIndex = i;
                currentSum += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == s)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write(k < j ? array[k] + " " : array[k] + "\n");
                        }
                        break;
                    }

                }
                currentSum = 0;
            }
        }
    }
}
