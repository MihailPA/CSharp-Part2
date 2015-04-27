//Problem 2. Binary to decimal
//Write a program to convert binary numbers to their decimal representation.

using System;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a binary number: ");
            string binary = Console.ReadLine();
            long inDecimal = Convert.ToInt32(binary, 2);
            Console.WriteLine("Decimal representation to binary number {0} is {1}", binary, inDecimal);
        }
    }
}
