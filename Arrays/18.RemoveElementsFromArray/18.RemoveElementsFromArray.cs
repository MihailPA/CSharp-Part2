﻿//Problem 18.* Remove elements from array
//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _18.RemoveElementsFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number elements in the array N=");
            int n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("element[{0}]=", i);
                array.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] > array[i + 1] || array[i] < array[0])
                {
                    array.Remove(array[i]);
                }
            }
            for (int i = 0; i < array.Count; i++)
            {
                Console.Write(i < array.Count - 1 ? array[i] + ", " : array[i] + "\n");
            }
        }
    }
}
