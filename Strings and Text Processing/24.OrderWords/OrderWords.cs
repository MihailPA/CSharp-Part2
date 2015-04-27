//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            string text = /*Console.ReadLine()*/"Write A program that reads a list of words separated by spaces and prints the list in an alphabetical order";
            string[] letters = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(letters);
            Console.WriteLine(String.Join("\n", letters));
        }
    }
}
