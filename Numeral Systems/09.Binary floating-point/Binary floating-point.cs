﻿//Problem 9.* Binary floating-point
//Write a program that shows the internal binary representation of given 32-bit signed floating-point 
//number in IEEE 754 format (the C# type float).

using System;
using System.Globalization;
using System.Threading;

namespace _09.Binary_floating_point
{
    class BinaryFloatingPoint
    {
        static string FloatToBinary(float number)
        {
            int intNumber = BitConverter.ToInt32(BitConverter.GetBytes(number), 0);
            return Convert.ToString(intNumber, 2);
        }

        static string GetExponent(string inBinary)
        {
            return inBinary.Substring(0, 8);
        }

        static string GetMantissa(string inBinary)
        {
            return inBinary.Substring(8);
        }

        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter floating-point number: ");
            float number = float.Parse(Console.ReadLine());

            int sign = number > 0 ? 0 : 1;
            number = Math.Abs(number);
            string inBinary = FloatToBinary(number);

            if ((int)number == 0 || (int)number == 1)
            {
                inBinary = "0" + inBinary;
            }
            Console.WriteLine("Sign: {0}", sign);
            Console.WriteLine("Exponent: {0}", GetExponent(inBinary));
            Console.WriteLine("Mantissa: {0}", GetMantissa(inBinary));
        }
    }
}
