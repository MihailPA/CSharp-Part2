//Problem 2. Reverse string
//Write a program that reads a string, reverses it and prints the result at the console.

using System;
using System.Text;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            Console.WriteLine(reversed);
        }
    }
}
