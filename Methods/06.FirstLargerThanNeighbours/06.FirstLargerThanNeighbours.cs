//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int[] arr = { 4, 5, 6, 3, 20, 23, 34, 10, 5, 6, 7 };
            Console.WriteLine("First element larger that its neighbors is on position: {0}", CheckNeighbors(arr));
        }
        static int CheckNeighbors(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        return i;
                    }
                }
                else if (arr[i] == arr.Length - 1)
                {
                    if (arr[i] > arr[i - 1])
                    {
                        return i;
                    }
                }
                else if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
