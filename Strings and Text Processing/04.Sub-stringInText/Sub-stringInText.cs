//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is in
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9

using System;

namespace _04.Sub_stringInText
{
    class SubstringInText
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter sub-string:");
            string sub = Console.ReadLine();
            Console.WriteLine(TextCounter(input, sub));
        }

        private static int TextCounter(string input, string sub)
        {
            int counter = 0;
            int index = -1;
            while (true)
            {
                index = input.IndexOf(sub, index + 1);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
