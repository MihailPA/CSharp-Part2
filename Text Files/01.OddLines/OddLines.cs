//Problem 1. Odd lines
//Write a program that reads a text file and prints on the console its odd lines.


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("text.txt", Encoding.Unicode);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if ((lineNumber & 1) == 1) // check if odd
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                }
            }
        }
    }
}
