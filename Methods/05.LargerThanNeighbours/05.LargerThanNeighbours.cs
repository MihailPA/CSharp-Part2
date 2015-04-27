//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is 
//larger than its two neighbours (when such exist).

using System;

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int[] numbers = { 6, 13, -2, 24, 0, 23, -23, 1, 4, 5 };
            Console.Write("Enter position:");
            int index = int.Parse(Console.ReadLine());

            CheckIfBiggerThanNeighbours(numbers, index);
        }

        static void CheckIfBiggerThanNeighbours(int[] array, int index)
        {
            if (index - 1 < 0 || index + 1 > array.Length - 1)
            {
                Console.WriteLine("Does not have left or right neighbor!");
            }
            else
            {
                if ((array[index] > array[index - 1]) && (array[index] > array[index + 1]))
                {
                    Console.WriteLine("The number at index {0} is bigger than its neighbors", index);
                }
                else
                {
                    Console.WriteLine("The number at index {0} is not bigger than its neighbors", index);
                }
            }
        }
    }
}
