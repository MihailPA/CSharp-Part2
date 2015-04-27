//Problem 3. Day of week
//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is {0:dddd}!", today);
        }
    }
}
