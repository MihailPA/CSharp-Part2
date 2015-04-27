//Problem 10. Unicode characters
//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:
//input	output
//Hi!	\u0048\u0069\u0021

using System;
using System.Text;


namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();

            foreach (var item in text)
            {
                string output = String.Format("\\u{0:X4}", (int)item);
                Console.Write(output);
            }

            Console.WriteLine();
        }
    }
}
