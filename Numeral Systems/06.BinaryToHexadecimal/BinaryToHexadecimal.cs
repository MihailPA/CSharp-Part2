﻿//Problem 6. binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

namespace _06.BinaryToHexadecimal
{
    class BinaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter binary number: ");
            string binary = Console.ReadLine();
            Console.WriteLine("Hexademical represantation: {0}", Convert.ToInt64(binary, 2).ToString("X"));
        }
    }
}
