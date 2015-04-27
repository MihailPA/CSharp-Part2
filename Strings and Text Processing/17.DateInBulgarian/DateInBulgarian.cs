//Problem 17. Date in Bulgarian
//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;
using System.Threading;

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
           

            Console.WriteLine("Enter date and time in format  \"day.month.year hour:minute:second\"");
           
            string inputOne = Console.ReadLine();
            string[] dateArr = inputOne.Split(new char[] { '.', ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            var date = new DateTime(Convert.ToInt32(dateArr[2]), Convert.ToInt32(dateArr[1]), Convert.ToInt32(dateArr[0]),
            Convert.ToInt32(dateArr[3]), Convert.ToInt32(dateArr[4]), Convert.ToInt32(dateArr[5]));
            
            Console.WriteLine(date);
            Console.Write("The date and time after 6 hours and 30 minutes will be: {0}", (date.AddHours(6)).AddMinutes(30));
            
            
        }
    }
}
