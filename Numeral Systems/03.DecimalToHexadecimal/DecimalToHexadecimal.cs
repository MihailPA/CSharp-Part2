//Problem 3. Decimal to hexadecimal
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Hexadecimal representation: {0}", number.ToString("X"));
        }
    }
}
