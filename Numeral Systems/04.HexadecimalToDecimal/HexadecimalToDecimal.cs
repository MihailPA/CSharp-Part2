//Problem 4. Hexadecimal to decimal
//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a hexademical number: ");
            string hex = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(hex, 16));
        }
    }
}
