//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace _09.DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main()
        {
            using (StreamWriter sw = new StreamWriter("../../result.txt"))
            {
                using (StreamReader sr = new StreamReader("../../text.txt"))
                {
                    string line;
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        counter++;
                        if ((counter & 1) == 1) // check if odd
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter("../../text.txt"))
            {
                using (StreamReader sr = new StreamReader("../../result.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);
                    }
                }

            }
            Console.WriteLine("The Odd Lines are deleted!");
        }
    }
}
