﻿//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

namespace _02.RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value {0} is {1}", i, rnd.Next(100, 200));
            }
        }
    }
}
