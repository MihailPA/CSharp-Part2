//Problem 11. Format number
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;
using System.Text;


namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Decimal: \n{0,15:D}", number);
            Console.WriteLine("Hexadecimal: \n{0,15:X}", number);
            Console.WriteLine("Percentage: \n{0,15:P0}", number);
            Console.WriteLine("Scientific notation:\n {0,14:E2}", number);
        }
    }
}
