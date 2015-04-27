//Problem 3. Line numbers
//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;


namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../text.txt", Encoding.ASCII);
            StreamWriter writer = new StreamWriter("../../target.txt", true);

            using (writer)
            {
                using (reader)
                {
                    string line = reader.ReadLine();
                    int counter = 0;
                    while (line != null)
                    {
                        counter++;
                        line = line.Insert(0, counter.ToString() + " ");
                        Console.WriteLine(line + " is being stored in target.txt");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
