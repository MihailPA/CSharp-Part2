//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;

namespace _18.Extracte_mails
{
    class ExtractEmails

    {
        static void Main()
        {
            string text = @"My email is ""gouemiq89@abv.bg"". My friend's email is ""gstudiootbora@gmail.com"".";
            Console.WriteLine(text);
            Console.WriteLine("The emails are:");
            Console.WriteLine(String.Join("\n", ExtractEmail(text)));
        }

        static List<string> ExtractEmail(string text)
        {
            var emails = new List<string>();
            string[] email = text.Split(new char[] { '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in email)
            {
                if (word.Contains("@"))
                {
                    emails.Add(word);
                }
            }
            return emails;
        }
    }
}
