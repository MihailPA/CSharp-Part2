//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of 
//integers by using the Binary search algorithm.

using System;


namespace _11.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array members separated by space: ");
            string[] arrStr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrStr.Length];
            for (int i = 0; i < arrStr.Length; i++)
            {
                arr[i] = int.Parse(arrStr[i]);
            }

            Array.Sort(arr);

            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Enter number to search for: ");
            int num = int.Parse(Console.ReadLine());

            int startIndex = 0, endIndex = arr.Length - 1;

            while ((endIndex - startIndex) > 1)
            {
                int index = startIndex + (endIndex - startIndex) / 2;

                if (arr[index] == num) 
                { 
                    Console.WriteLine("{0} is at position {1}", num, index); 
                    return; 
                }
                else if (arr[index] > num)
                {
                    endIndex = index;
                }
                else if (arr[index] < num)
                {
                    startIndex = index;
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }

           
        }
    }
}
