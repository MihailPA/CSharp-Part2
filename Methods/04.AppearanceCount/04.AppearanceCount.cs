//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int[] numbers = { 3,5,-14,3,4,132,3,151,3,4151,2312423,3,-132 };
            int searchedNumber = 3;

            int count = CountGivenNumber(numbers, searchedNumber);

            Console.WriteLine("The searched number appears {0} times.", count);
        }

        static int CountGivenNumber(int[] array, int search)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (search == array[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
