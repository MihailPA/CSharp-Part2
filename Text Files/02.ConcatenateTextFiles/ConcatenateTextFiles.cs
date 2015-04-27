//Problem 2. Concatenate text files
//Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            using (StreamWriter write = new StreamWriter(@"..\..\concatenatedText.txt", true))
            {
                using (StreamReader firstReader = new StreamReader(@"..\..\firstText.txt"))
                {
                    string line = firstReader.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine(line);
                        line = firstReader.ReadLine();
                    }
                }

                using (StreamReader secondReader = new StreamReader(@"..\..\secondText.txt"))
                {
                    string line = secondReader.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine(line);
                        line = secondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("Concatenation is done.");
        }
    }
}
