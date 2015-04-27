//Problem 19. Dates from text in Canada
//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace _19.DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            Console.WriteLine("Enter your text /Dates in format:DD.MM.YYYY/:");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                                CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                }
                catch (FormatException)
                {
                }
            }
            
        }
    }
}
